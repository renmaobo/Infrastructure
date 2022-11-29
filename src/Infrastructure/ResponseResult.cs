// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	ResponseResult
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/11/29 下午11:15
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/11/29 下午11:15
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
namespace Infrastructure
{
	/// <summary>
	/// 响应结果
	/// </summary>
	public class ResponseResult
	{
		/// <summary>
		/// 状态
		/// </summary>
		public  bool Status { get; set; }

		/// <summary>
		/// 错误信息
		/// </summary>
		public string? ErrMsg { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="errMsg">错误信息</param>
        public ResponseResult(bool status = default, string? errMsg = default) {
			this.Status = status;
			this.ErrMsg = errMsg;
		}
	}

	public class ResponseResult<Tdata> : ResponseResult {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="errMsg">错误信息</param>
		/// <param name="data">指定数据</param>
		public ResponseResult(bool status = default, string? errMsg = default, Tdata? data = default)
			: base(status, errMsg) {
			this.Data = data;
		}

        /// <summary>
        /// 指定数据
        /// </summary>
        public Tdata? Data { get; set; }
	}
}

