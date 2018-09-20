using System;

namespace Notes.Client
{
    static class Program
    {
        static void Main(string[] args)
        { 
            var service = new BLL.Services.NotesService();

            var result = service.GetNote(25);
      
            Console.WriteLine("If you see this message, this means that the client of Notes.BLL.dll works correctly");
            Console.ReadKey();
        }
    }
}
