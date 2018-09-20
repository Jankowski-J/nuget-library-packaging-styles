using Notes.DAL.Entities;

namespace Notes.DAL.Repositories
{
    public interface INotesRepository
    {
        Note GetNote(long noteId);
    }

    public class NotesRepository : INotesRepository
    {
        public Note GetNote(long noteId)
        {
            return new Note
            {
                NoteId = noteId,
                Text = $"Some note {noteId}"
            };
        }
    }
}
