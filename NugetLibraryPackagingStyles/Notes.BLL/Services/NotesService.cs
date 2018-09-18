using Notes.BLL.Model;
using Notes.DAL.Repositories;

namespace Notes.BLL.Services
{
    public class NotesService
    {
        private readonly INotesRepository notesRepository;

        public NotesService()
        {
            notesRepository = new NotesRepository();
        }

        public NoteModel GetNote(long noteId)
        {
            var note = notesRepository.GetNote(noteId);

            return new NoteModel
            {
                NoteId = note.NoteId,
                Text = note.Text
            };
        }
    }
}
