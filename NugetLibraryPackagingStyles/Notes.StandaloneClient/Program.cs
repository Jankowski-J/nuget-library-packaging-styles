using System;

namespace Notes.StandaloneClient
{
    static class Program
    {
        static void Main(string[] args)
        {
            var service = new BLL.Standalone.Services.NotesService();

            var result = service.GetNote(25);
            Console.ReadKey();
        }
    }
}
