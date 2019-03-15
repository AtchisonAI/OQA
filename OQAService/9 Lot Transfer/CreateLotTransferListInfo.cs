using OQAContract;
using System;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<LotTransferListSave> CreateLotTransferListInfo(ModelRsp<LotTransferListSave> LotTransferListSave)
        {
            try
            {
                //定义服务过程中使用的结构
                ModelRsp<LotTransferListSave> In_node = new ModelRsp<LotTransferListSave>();         //定义服务传入系统数据结构
                ModelRsp<LotTransferListSave> Out_node = new ModelRsp<LotTransferListSave>();        //定义服务传出系统数据结构
                //DefectCodeSave Out_list = new DefectCodeSave();                          //定义服务传出业务数据结构

                UpdateModelListReq<ISPLOTSTS> Do_Update = new UpdateModelListReq<ISPLOTSTS>();//定义数据库操作新增动作传入结构
                UpdateModelListReq<PKGSHPDAT> Do_Save = new UpdateModelListReq<PKGSHPDAT>();
                ModelListRsp<PKGSHPDAT> Do_message = new ModelListRsp<PKGSHPDAT>();         //定义数据库操作新增动作输出结构
                ModelListRsp<ISPLOTSTS> Do_updatemessage = new ModelListRsp<ISPLOTSTS>();         //定义数据库操作新增动作输出结构
                PKGSHPDAT T_PKGSHIPLIST = new PKGSHPDAT(); //定义临时表结构
                ISPLOTSTS T_UPDATEISPLOTSTS = new ISPLOTSTS();

                //传入数据赋值
                In_node.model = LotTransferListSave.model;

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

                            if (In_node.model.IN_PART_ID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_PART_ID is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_LOTID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_LOTID is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_QTY.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_QTY is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_ISP_RESULT.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_ISP_RESULT is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_SHIPID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_SHIPID is null!";
                                return Out_node;
                            }
                            //传入数据赋值
                            T_PKGSHIPLIST.PartId = In_node.model.IN_PART_ID;
                            T_PKGSHIPLIST.LotId = In_node.model.IN_LOTID;
                            T_PKGSHIPLIST.Qty = In_node.model.IN_QTY;
                            T_PKGSHIPLIST.InspectResult = In_node.model.IN_ISP_RESULT;
                            T_PKGSHIPLIST.ShipId = In_node.model.IN_SHIPID;


                            //T_ISPDFTDEF.TransSeq = 0;
                            T_PKGSHIPLIST.UpdateTime = " ";
                            T_PKGSHIPLIST.UpdateUserId = " ";
                            T_PKGSHIPLIST.CreateTime = GetSysTime();
                          //  T_PKGSHIP.CreateUserId = " ";

                            //调用数据库操作
                            Do_Save.operateType = OperateType.Insert;
                            Do_Save.models.Add(T_PKGSHIPLIST) ;
                            BeginTrans();
                            //执行
                            UpdateModels(Do_Save, Do_message, true);
                            EndTrans();

                            break;

                        case '2':

                            // TODO

                            break;
                    }

                    if (Do_message._success == true)
                    {
                        Out_node._success = true;
                        Out_node._MsgCode = "Program Success.";
                    }
                    else
                    {
                        Out_node._success = false;
                        Out_node._ErrorMsg = Do_message._ErrorMsg;
                    }

                }
               

                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_UPDATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数

                            if (In_node.model.IN_LOTID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_LOTID is null!";
                                return Out_node;
                            }


                            T_UPDATEISPLOTSTS.LotId = In_node.model.IN_LOTID;

                            ////输入数据表主键
                            T_UPDATEISPLOTSTS.Status = "TransferOut";
                            T_UPDATEISPLOTSTS.TransSeq = In_node.model.D_TRANSSEQ;
                            T_UPDATEISPLOTSTS.UpdateTime = GetSysTime();
                            T_UPDATEISPLOTSTS.UpdateUserId = " ";

                            Do_Update.operateType = OperateType.Update;
                            Do_Update.models.Add(T_UPDATEISPLOTSTS);
                            BeginTrans();
                            //执行
                            UpdateModels(Do_Update, Do_updatemessage, true);
                            EndTrans();

                            break;

                        case '2':

                            // TODO

                            break;
                    }
                    if (Do_updatemessage._success == true)
                    {
                        Out_node._success = true;
                        Out_node._MsgCode = "Program Success.";
                    }
                    else
                    {
                        Out_node._success = false;
                        Out_node._ErrorMsg = Do_updatemessage._ErrorMsg;
                    }


                }


                return Out_node;
            }
            catch (Exception ex)
            {
                ModelRsp<LotTransferListSave> Out_node = new ModelRsp<LotTransferListSave>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }



    }

}
