using LiteDB;

namespace Media_Organiser
{
    class DatabaseManager
    {

        public void UploadFile(string fileDir, string name)
        {
            using (LiteDatabase db = new LiteDatabase("Database.db"))
            {
                
            }
        }

    }
}
