// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	LinkConfig
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/11/29 下午11:43
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/11/29 下午11:43
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
using System.Collections.Generic;
using Infrastructure.Entities;
namespace Infrastructure.ShortLineService.Entities
{
	/// <summary>
	/// 链接配置
	/// </summary>
	public class LinkConfig : BaseEntity
    {
		/// <summary>
		/// 调用码
		/// </summary>
		public string? InvokeCode { get; set; }

		/// <summary>
		/// 链接地址
		/// </summary>
		public string? Url { get; set; }

		/// <summary>
		/// 临时
		/// </summary>
        public bool IsTemp { get; set; } = false;

		/// <summary>
		/// 有效期
		/// </summary>
		public long ExpiresIn { get; set; }

        public override bool FormatValid(ref List<string> errMsgs)
        {
			if (this.InvokeCode.IsNullOrEmpty()) return false;
            return base.FormatValid(ref errMsgs);
        }
    }
}

