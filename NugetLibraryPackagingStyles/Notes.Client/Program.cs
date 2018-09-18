using System;

namespace Notes.Client
{
    static class Program
    {
        static void Main(string[] args)
        { 
            var service = new BLL.Services.NotesService();

            var result = service.GetNote(25);
            Console.ReadKey();
        }
    }
}
