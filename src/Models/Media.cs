﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Models
{
    public class Media
    {
        public Media()
        {
            Id = GeneratorId.Generate("media");
            CreatedTime = DateTime.Now;
        }

        public string Id { get; set; }
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public DateTime? CreatedTime { get; set; }      

        public string GetDataBase64()
        {
            var base64 = Convert.ToBase64String(Content);
            return $"data:{ContentType};base64,{base64}";
        }

        public static string GetDataBase64(byte[] content, string contentType)
        {
            var base64 = Convert.ToBase64String(content);            
            return $"data:{contentType};base64,{base64}";
        }
    }
}
