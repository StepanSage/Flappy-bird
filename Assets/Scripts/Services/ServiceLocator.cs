using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Services 
{
    public  class ServiceLocator 
    {
        private static Dictionary<string , IServices > AllServices = new Dictionary<string,IServices>();

        public static ServiceLocator _currentService;

        public static void Init()
        {
            _currentService = new ServiceLocator();
        }


        public void Register<T>(T service) where T: IServices
        { 
            var key = typeof(T).Name;

            if(AllServices.ContainsKey(key))
            {
                new Exception();
                UnRegister<T>(service);
            }

            AllServices.Add(key, service);
        }

        public void UnRegister<T>(T Service) where T : IServices
        {
            var key = typeof(T).Name;
            if(!AllServices.ContainsKey(key))
            {
                new Exception();
            }

            AllServices.Remove(key);
        }


        public T GetSerice<T>() where T : IServices
        {
            var key = typeof(T).Name;

            if(!AllServices.ContainsKey(key))
            {
                new Exception();
            }

            return (T) AllServices[key]; 

        }



    }

}

