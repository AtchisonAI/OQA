using OQAService.Contract;
using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<DefectCodeSave> CreateDefectCodeInfo(ModelRsp<DefectCodeSave> DefectCode)
        {
            try
            {
                //定义服务过程中使用的结构
                UpdateModelListReq<ISPDFTDEF> Do_Save = new UpdateModelListReq<ISPDFTDEF>();
                ModelListRsp<ISPDFTDEF> Do_message = new ModelListRsp<ISPDFTDEF>();
                ISPDFTDEF T_ISPDFTDEF = new ISPDFTDEF();

                ModelRsp<DefectCodeSave> In_node = new ModelRsp<DefectCodeSave>();
                ModelRsp<DefectCodeSave> Out_node = new ModelRsp<DefectCodeSave>();
                DefectCodeSave Out_list = new DefectCodeSave();

                In_node.model = DefectCode.model;

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

                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_CREATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数

                            if (In_node.model.IN_ISP_CODE.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_ISP_CODE is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_ISP_TYPE.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_ISP_TYPE is null!";
                                return Out_node;
                            }
                            //传入数据赋值
                            T_ISPDFTDEF.InspectType = In_node.model.IN_ISP_TYPE;
                            T_ISPDFTDEF.DefectCode = In_node.model.IN_ISP_CODE;
                            T_ISPDFTDEF.DftDesc = In_node.model.IN_CODE_DESC;


                            //调用数据库操作
                            Do_Save.opreateType = OperateType.Insert;
                            Do_Save.models.Add(T_ISPDFTDEF) ;
                            BeginTrans();
                            UpdateModelingObjects(Do_Save, Do_message, true);
                            EndTrans();

                            break;

                        case '2':

                            // TODO

                            break;
                    }
                    
                }

                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_UPDATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数

                            if (In_node.model.IN_ISP_CODE.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_ISP_CODE is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_ISP_TYPE.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_ISP_TYPE is null!";
                                return Out_node;
                            }
                            //传入数据赋值
                            T_ISPDFTDEF.InspectType = In_node.model.IN_ISP_TYPE;
                            T_ISPDFTDEF.DefectCode = In_node.model.IN_ISP_CODE;
                            T_ISPDFTDEF.DftDesc = In_node.model.IN_CODE_DESC;


                            //调用数据库操作
                            Do_Save.opreateType = OperateType.Update;
                            Do_Save.models.Add(T_ISPDFTDEF);
                            BeginTrans();
                            UpdateModelingObjects(Do_Save, Do_message, true);
                            EndTrans();

                            break;

                        case '2':

                            // TODO

                            break;
                    }

                }

                if (Do_message._success == true)
                {
                    Out_node.model._success = true;
                    Out_node._MsgCode = "Program Success.";
                }
                else
                {
                    Out_node.model._success = false;
                    Out_node.model._ErrorMsg = Do_message._ErrorMsg;
                }

                return Out_node;
            }
            catch (Exception ex)
            {
                ModelRsp<DefectCodeSave> Out_node = new ModelRsp<DefectCodeSave>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }



    }

}
