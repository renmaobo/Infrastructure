// ============================================================
// Copyright (C) 2022 RenMaoBo All Rights Reserved.
// FileName:    	ResponseResult
// Version:       	$V1.0.0.0
// Create By:   	maobo
// Email:           renmaobo@outlook.com
// Create Time:  	2022/11/29 下午11:10
//
// Description:
//
// ============================================================
// Modify Mark
// Modify Time:  2022/11/29 下午11:10
// Modify By:    maobo
// Version:      V1.0.0.0
// Description:
//
// ============================================================
using System;
namespace Infrastructure.Entities
{
	/// <summary>
	/// 响应结果
	/// </summary>
	public class ResponseResult
	{
		public ResponseResult()
		{
		}
	}

	public class ResponseResult<Tdata> : ResponseResult{
	}
}

