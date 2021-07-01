using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            IRepository<Paciente> p = new EFRepository<Paciente>();
            var pacientes =  p.ToList();
            IFile file = FileFactory.GetFile();

            file.Read("44.tif");
            
        }



    }
    public class Paciente
    {

    }

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> ToList();
    }

    public class EFRepository<T> : IRepository<T> where T : class
    {
        public IEnumerable<T> ToList()
        {
            throw new NotImplementedException();
        }
    }

    public class RawSql<T> : IRepository<T> where T : class
    {
        public IEnumerable<T> ToList()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFile
    {
        byte[] Read(string filename);

        void Write(string filename, byte[] contenido);
    }

    // file storage
    public class LocalFile : IFile
    {
        public byte[] Read(string filename)
        {
            return File.ReadAllBytes(filename);
        }

        public void Write(string filename, byte[] contenido)
        {
            File.WriteAllBytes(filename, contenido);
        }
    }

    public class AzureFile : IFile
    {


        public byte[] Read(string filename)
        {
            throw new NotImplementedException();
        }

        public void Write(string filename, byte[] contenido)
        {
            throw new NotImplementedException();
        }
    }

    public class FtpFile : IFile
    {
        public byte[] Read(string filename)
        {
            throw new NotImplementedException();
        }

        public void Write(string filename, byte[] contenido)
        {
            throw new NotImplementedException();
        }
    }


}
