using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFModels
{
    public enum CompareType
    {
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanOrEqual,
        Include,
        NotEqual,
        Equal
    }

    public enum LogicCondition {
        AndAlso,
        OrElse
    }

    public enum SortType
    {
        ASC,
        DESC
    }

    [DataContract]
    public class QueryCondition
    {
        [DataMember]
        public string paramName;

        [DataMember]
        public string value;

        [DataMember]
        public CompareType compareType;

        [DataMember]
        public LogicCondition conditionType;
    }

    [DataContract]
    public class SortCondition
    {
        [DataMember]
        public string paramName;

        [DataMember]
        public SortType sortType;
    }
}
