using OQAContract;
using System;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<LotTransferSave> CreateLotTransferInfo(ModelRsp<LotTransferSave> LotTransferSave)
        {
            try
            {
                //定义服务过程中使用的结构
                ModelRsp<LotTransferSave> In_node = new ModelRsp<LotTransferSave>();         //定义服务传入系统数据结构
                ModelRsp<LotTransferSave> Out_node = new ModelRsp<LotTransferSave>();        //定义服务传出系统数据结构
                //DefectCodeSave Out_list = new DefectCodeSave();                          //定义服务传出业务数据结构

                UpdateModelListReq<PKGSHPSTS> Do_Save = new UpdateModelListReq<PKGSHPSTS>();//定义数据库操作新增动作传入结构
                ModelListRsp<PKGSHPSTS> Do_message = new ModelListRsp<PKGSHPSTS>();         //定义数据库操作新增动作输出结构
                PKGSHPSTS T_PKGSHIP = new PKGSHPSTS(); //定义临时表结构

                //传入数据赋值
                In_node.model = LotTransferSave.model;

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
                            if (In_node.model.IN_CREATER.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_CREATER is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_QTY.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_QTY is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_SHIP_DATE.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_SHIP_DATE is null!";
                                return Out_node;
                            }
                            if (In_node.model.IN_SHIPID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_SHIPID is null!";
                                return Out_node;
                            }
                            //传入数据赋值
                            T_PKGSHIP.PartId = In_node.model.IN_PART_ID;
                            T_PKGSHIP.CreateUserId = In_node.model.IN_CREATER;
                            T_PKGSHIP.Qty = In_node.model.IN_QTY;
                            T_PKGSHIP.ShipDate = In_node.model.IN_SHIP_DATE;
                            T_PKGSHIP.ShipId = In_node.model.IN_SHIPID;
                          

                            //T_ISPDFTDEF.TransSeq = 0;
                            T_PKGSHIP.UpdateTime = " ";
                            T_PKGSHIP.UpdateUserId = " ";
                            T_PKGSHIP.CreateTime = GetSysTime();
                          //  T_PKGSHIP.CreateUserId = " ";

                            //调用数据库操作
                            Do_Save.operateType = OperateType.Insert;
                            Do_Save.models.Add(T_PKGSHIP) ;
                            BeginTrans();
                            //执行
                            UpdateModels(Do_Save, Do_message, true);
                            EndTrans();

                            break;

                        case '2':

                            // TODO

                            break;
                    }
                    
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

                return Out_node;
            }
            catch (Exception ex)
            {
                ModelRsp<LotTransferSave> Out_node = new ModelRsp<LotTransferSave>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }



    }

}
