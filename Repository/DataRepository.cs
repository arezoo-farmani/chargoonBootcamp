using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Domain.DataInterfaces;
using Domain.RepositoryInterfaces;

namespace Repository
{
    public class DataRepository<T> : IRepository<T> where T : IBaseEntity
    {
        private readonly string _directoryPath = @"..\..\..\Repository\Files";
        private readonly string _filePath;
        public DataRepository()
        {
            _filePath = _directoryPath + $@"\{typeof(T).Name}s.json";
            CreateFolderAndFile();
        }

        private void CreateFolderAndFile()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            if (!File.Exists(_filePath))
            {
                using (FileStream fs = File.Create(_filePath)) { };
            }
        }

        public List<T> GetAll()
        {
            string jsonData = File.ReadAllText(_filePath);
            List<T> allData = JsonConvert.DeserializeObject<List<T>>(jsonData);
            return allData ?? new List<T>();
        }

        public void SaveAll(List<T> entities)
        {
            string jsonData = JsonConvert.SerializeObject(entities);
            File.WriteAllText(_filePath, jsonData);
        }

        public Guid Save(T entity)
        {
            List<T> entities = GetAll();
            entities.Add(entity);
            string jsonData = JsonConvert.SerializeObject(entities);
            File.WriteAllText(_filePath, jsonData);
            return entity.Guid;
        }

        public void Update(T entity)
        {
            List<T> entities = GetAll();
            T selectedEntity = entities.Find(item => item.Guid.Equals(entity.Guid));
            entities.Remove(selectedEntity);
            entities.Add(entity);
            string jsonData = JsonConvert.SerializeObject(entities);
            File.WriteAllText(_filePath, jsonData);
        }

        public T GetByGuid(Guid guid)
        {
            string jsonData = File.ReadAllText(_filePath);
            List<T> entities = JsonConvert.DeserializeObject<List<T>>(jsonData);
            T entity = entities.Find(item => item.Guid.Equals(guid));
            return entity;
        }
    }
}
