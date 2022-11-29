// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	BaseEntity
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/11/29 下午11:14
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/11/29 下午11:14
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using System.Collections.Generic;

namespace Infrastructure.Entities
{
	/// <summary>
	/// 基础实体
	/// </summary>
	public class BaseEntity
	{
        /// <summary>
        /// 格式验证
        /// </summary>
        /// <param name="errMsgs">错误信息列表</param>
        /// <returns>
        /// <para>true:有效</para>
        /// <para>false:无效</para>
        /// </returns>
        public virtual bool FormatValid(ref List<string> errMsgs) => true;
	}

	/// <summary>
	/// 基础实体
	/// </summary>
	/// <typeparam name="Tid">自定义编号类型</typeparam>
	public class BaseEntity<Tid> : BaseEntity {
        /// <summary>
        /// 数据编号
        /// </summary>
        public Tid? Id { get; set; }
    }
}

