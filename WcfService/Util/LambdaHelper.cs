using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WCFModels;

namespace WcfService
{
    public static class LambdaHelper
    {
        public static Expression<Func<T, bool>> LambdaBuilder<T>(IList<QueryCondition> qesList)
        {
            Assert(qesList.Count > 0);
            var typeObject = Expression.Parameter(typeof(T), "x");
            Expression bin = Expression.Equal(Expression.Constant(1), Expression.Constant(1));

            foreach (QueryCondition q in qesList)
            {
                Expression tmpBin = null;
                MemberExpression memberFiled = Expression.PropertyOrField(typeObject, q.paramName);
                Expression value = Expression.Constant(q.value);

                switch (q.compareType)
                {
                    case CompareType.GreaterThan:
                        tmpBin = Expression.GreaterThan(memberFiled, value);
                        break;
                    case CompareType.GreaterThanOrEqual:
                        tmpBin = Expression.GreaterThanOrEqual(memberFiled, value);
                        break;
                    case CompareType.LessThan:
                        tmpBin = Expression.LessThan(memberFiled, value);
                        break;
                    case CompareType.LessThanOrEqual:
                        tmpBin = Expression.LessThanOrEqual(memberFiled, value);
                        break;
                    case CompareType.Include:
                        //目前只支持string格式的模糊查询
                        var method = typeof(string).GetMethod("Contains", new Type[] { typeof(string) });
                        tmpBin = Expression.Call(memberFiled, method, value);
                        break;
                    case CompareType.NotEqual:
                        tmpBin = Expression.NotEqual(memberFiled, value);
                        break;
                    case CompareType.Equal:
                    default:
                        tmpBin = Expression.Equal(memberFiled, value);
                        break;
                }

                switch (q.conditionType)
                {
                    case LogicCondition.OrElse:
                        bin = Expression.OrElse(bin, tmpBin);
                        break;
                    case LogicCondition.AndAlso:
                    default:
                        bin = Expression.AndAlso(bin, tmpBin);
                        break;
                }
            }

            var lambda = Expression.Lambda<Func<T, bool>>(bin, typeObject);
            return lambda;
        }

        private static void Assert(bool v)
        {
            if (!v)
            {
                throw new NotImplementedException();
            }
        }

        public static Expression<Func<T, object>> LambdaBuilderByName<T>(string paramName)
        {
            //1.创建表达式参数（指定参数或变量的类型:p）
            ParameterExpression param = Expression.Parameter(typeof(T), "x");
            //2.构建表达式体(类型包含指定的属性:p.Name)
            MemberExpression body = Expression.Property(param, paramName);
            //3.根据参数和表达式体构造一个lambda表达式
            return Expression.Lambda<Func<T, object>>(body, param);
        }
    }
}