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
                            //传入数据赋值
                            if (In_node.model.INSERTPKGSHPDAT_list.Count > 0)
                            {
                                int i;
                                for (i = 0; i < In_node.model.INSERTPKGSHPDAT_list.Count; i++)
                                {
                                    In_node.model.INSERTPKGSHPDAT_list[i] .ShipId = In_node.model.IN_SHIPID;
                                    In_node.model.INSERTPKGSHPDAT_list[i] .CreateUserId = In_node.model.S_USER_ID;
                                    In_node.model.INSERTPKGSHPDAT_list[i] .UpdateTime = " ";
                                    In_node.model.INSERTPKGSHPDAT_list[i] .UpdateUserId = " ";
                                    In_node.model.INSERTPKGSHPDAT_list[i].CreateTime = GetSysTime();

                                }

                                Do_Save.models = In_node.model.INSERTPKGSHPDAT_list;
                                Do_Save.operateType = OperateType.Insert;
                                //  BeginTrans();
                                //执行
                                UpdateModels(Do_Save, Do_message, true);
                             //   EndTrans();

                            }
                            else {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "T_PKGSHIPLIST is null!";
                                return Out_node;
                            }
                            

                            //调用数据库操作
                           
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

                           


                            if (In_node.model.INSERTPKGSHPDAT_list.Count > 0)
                            {
                                int i;
                                for (i = 0; i < In_node.model.INSERTPKGSHPDAT_list.Count; i++)
                                {
                                    ISPLOTSTS T_UPDATEISPLOTSTS = new ISPLOTSTS();


                                    T_UPDATEISPLOTSTS.LotId = In_node.model.INSERTPKGSHPDAT_list[i].LotId;
                                    T_UPDATEISPLOTSTS.Status = ISPStatus.TransferOut;
                                    T_UPDATEISPLOTSTS.TransSeq = In_node.model.INSERTPKGSHPDAT_list[i].TransSeq;
                                    T_UPDATEISPLOTSTS.UpdateTime = GetSysTime();
                                    T_UPDATEISPLOTSTS.UpdateUserId = In_node.model.S_USER_ID;

                                    Do_Update.models.Add(T_UPDATEISPLOTSTS);
                                    Do_Update.operateType = OperateType.Update;

                                }
                                
                                //BeginTrans();
                                //执行
                                UpdateModels(Do_Update, Do_updatemessage, true);
                                SaveISPLotHistory(ISPStatus.TransferOut,In_node.model.S_USER_ID,Do_updatemessage );
                               // EndTrans();
                            }
                            else
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "T_UPDATEISPLOTSTS is null!";
                                return Out_node;
                            }

                            ////输入数据表主键


                           

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
