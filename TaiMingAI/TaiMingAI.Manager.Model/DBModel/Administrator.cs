﻿using System;

namespace TaiMingAI.Manager.Model
{
    public class Administrator
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 密码（MD5 32位加密）
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 手机号码（11位）
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// -1:注销；0:未审核；1:审核通过；
        /// </summary>
        public int State { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }

}
