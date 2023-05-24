﻿using System.Net;

namespace EmpresaPedidos.UAPI
{
    public class Crud <T>
    {

        public  T[] Select(string Url) 
        {
            try
            {
                using (var api = new WebClient()) 
                { 
                api.Headers.Add("Content-Type", "application/json");
                var json = api.DownloadString(Url);
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T[]>(json);
                return data;     
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Ha sucedido un error inesperado (" +ex.Message + ")");
                
            }

        }


        public T Select_ById(string Url, string id)
        {
            try
            {
                using (var api = new WebClient())
            {
                api.Headers.Add("Content-Type", "application/json");
                var json = api.DownloadString(Url + "/" + id);
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                return data;
            }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }

        public void Update(string Url, string v, T data) 
        {
            try
            {

                using (var api = new WebClient())
            {
                api.Headers.Add("Content-Type", "application/json");
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                api.UploadString(Url,"PUT",json);   
            }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }

        public T Insert(string Url, T data) 
        {
            try
            {
                using (var api = new WebClient()) 
            {
                api.Headers.Add("Content-type", "Application/json");
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                json = api.UploadString(Url,"POST", json);
                data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                return data;

            }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }

        public void Delete(string Url, string id)
            
        {
            try
            {
                using (var api = new WebClient())
            {
                api.Headers.Add("Content-Type", "application/json");
                api.UploadString(Url + "/" + id, "DELETE","" );
            }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }


        }
    }
}