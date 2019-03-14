using NPoco;
using OQAContract;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<ImageSave> SaveImageInfo(ModelRsp<ImageSave> ImageSave)
        {

            //定义服务过程中使用的结构
            ModelRsp<ImageSave> In_node = new ModelRsp<ImageSave>();         //定义服务传入系统数据结构
            ModelRsp<ImageSave> Out_node = new ModelRsp<ImageSave>();        //定义服务传出系统数据结构
                                                                             //DefectCodeSave Out_list = new DefectCodeSave();                          //定义服务传出业务数据结构

            UpdateModelReq<ISPIMGDEF> Do_Save = new UpdateModelReq<ISPIMGDEF>();//定义数据库操作新增动作传入结构
            ModelRsp<ISPIMGDEF> Do_message = new ModelRsp<ISPIMGDEF>();         //定义数据库操作新增动作输出结构
            ISPIMGDEF T_ISPIMGDEF = new ISPIMGDEF(); //定义临时表结构

            //传入数据赋值
            In_node.model = ImageSave.model;
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
                        string SysTime = GetSysTime();
                        string ImagePath;
                        //保存图片
                        ImagePath = SavePic(In_node.model.PicStreamBase64, SysTime);
                        T_ISPIMGDEF = ImageSave.model.IspImgeDef;
                        T_ISPIMGDEF.CreateTime = SysTime;
                        T_ISPIMGDEF.ImagePath = ImagePath;
                        T_ISPIMGDEF.ImageId = SysTime;
                        //调用数据库操作
                        InitTable(T_ISPIMGDEF);
                        Do_Save.operateType = OperateType.Insert;
                        Do_Save.model = T_ISPIMGDEF;
                        //执行
                        UpdateModel(Do_Save, Do_message, true);

                        break;

                        //case '2':

                        //    // TODO

                        //    break;
                }

            }

            if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_UPDATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                    case '1':
                        //验证业务级输入参数

                        //传入数据赋值
                        string SysTime = GetSysTime();
                        string ImagePath;
                        //删除旧图片
                        File.Delete(In_node.model.IspImgeDef.ImagePath);

                        //保存图片
                        ImagePath = SavePic(In_node.model.PicStreamBase64, SysTime);
                        T_ISPIMGDEF = ImageSave.model.IspImgeDef;
                        T_ISPIMGDEF.UpdateTime = SysTime;
                        T_ISPIMGDEF.ImagePath = ImagePath;
                        T_ISPIMGDEF.ImageId = SysTime;
                        //调用数据库操作
                        //InitTable(T_ISPIMGDEF);
                        Do_Save.operateType = OperateType.Update;
                        Do_Save.model = T_ISPIMGDEF;
                        //执行
                        UpdateModel(Do_Save, Do_message, true);

                        break;

                }

            }

            if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_DELETE)
            {
                //业务逻辑选择
                switch (In_node.model.C_TRAN_FLAG)
                {
                    case '1':
                        //验证业务级输入参数
                        //删除旧图片
                        File.Delete(In_node.model.IspImgeDef.ImagePath);

                        //调用数据库操作
                        //InitTable(T_ISPIMGDEF);
                        Do_Save.operateType = OperateType.Delete;
                        Do_Save.model = In_node.model.IspImgeDef;
                        //执行
                        UpdateModel(Do_Save, Do_message, false);

                        break;

                }

            }

            if (Do_message._success == true)
                {
                    Out_node.model.IspImgeDef = Do_message.model;
                    Out_node._success = true;
                    Out_node._MsgCode = "Program Success.";
                }
                else
                {
                    Out_node.model.IspImgeDef = Do_message.model;
                    Out_node._success = false;
                    Out_node._ErrorMsg = Do_message._ErrorMsg;
                }
                return Out_node;
            }
        }

    }

