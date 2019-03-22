using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;
using OQAContract;
using static WCFModels.OQA.PKGLabelPrintView;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<LotPndnInfoView> QryPndnInfo(ModelRsp<LotPndnInfoView> QryPndnInfo)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<LotPndnInfoView> In_node = new ModelRsp<LotPndnInfoView>();
                ModelRsp<LotPndnInfoView> Out_node = new ModelRsp<LotPndnInfoView>();

                UpdateModelListReq<OUT_PNDN> Do_Save = new UpdateModelListReq<OUT_PNDN>(); //定义数据库操作新增动作传入结构
                ModelListRsp<OUT_PNDN> Do_message = new ModelListRsp<OUT_PNDN>(); //定义数据库操作新增动作输出结构
                OUT_PNDN T_Out_Pndn = new OUT_PNDN(); //定义临时表结构

                //传入数据赋值

                In_node.model = QryPndnInfo.model;


                //验证系统级别输入参数

                if (In_node.model.C_PROC_STEP.Equals("") == true)
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_PROC_STEP is null!";
                    return Out_node;

                }

                if (In_node.model.C_TRAN_FLAG.Equals("") == true)
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_TRAN_FLAG is null!";
                    return Out_node;

                }

                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_VIEW)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {

                        case '1':
                        //验证业务级输入参数
                        
                        PageQueryReq.CurrentPage = 1;
                        PageQueryReq.ItemsPerPage = 200;


                        if (In_node.model.IN_LOT_ID.Trim().Equals("") == true)
                        {
                            Out_node._success = false;
                            Out_node._ErrorMsg = "IN_LOT_ID is null!";
                            return Out_node;
                        }

                        AddCondition(PageQueryReq, GetParaName<OUT_PNDN>(p => p.LotId),In_node.model.IN_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                       
                        var data = PageQuery<OUT_PNDN>(PageQueryReq);

                        Out_node.model.PndnList = data.models;
                        //if (Out_node.model.PndnList.Count == 0)
                        //{
                        //    Out_node._success = false;
                        //    Out_node._ErrorMsg = "Lot id is not found!";
                        //    return Out_node;
                        //}

                        break;

                        case '2':
                            // TODO
                            break;
                        case '3':
                            // TODO
                            break;
                    }

                }
                else
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_PROC_STEP异常";
                    return Out_node;
                }

                Out_node._success = true;
                Out_node._MsgCode = "Program Success.";
                return Out_node;

            }
            catch (Exception ex)
            {
                ModelRsp<LotPndnInfoView> Out_node = new ModelRsp<LotPndnInfoView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}