using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Media_Organiser
{
    static class DatabaseManager
    {

        private static string DATABASE_LOCATION = @".\\Database.db";
        private static string MEDIA_TABLE = "media";

        public static Objects.Record UploadFile(string fileDir, string name, string extension)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var records = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                Objects.Record record = new Objects.Record(fileDir+name, name, fileDir, extension, DateTime.Now);

                bool success = false;

                if (records.Find(x => x.id.StartsWith(record.id)) != null)
                    success = records.Update(record);
                else
                    success = records.Insert(record);

                String filename = fileDir + @"\" + name;
                db.FileStorage.Upload(filename.GetHashCode().ToString(), filename);

                if (success)
                    return record;
                return null;
            }
        }

        public static ArrayList GetAllRecords()
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var records = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                ArrayList list = new ArrayList();

                IEnumerator enumerator = records.FindAll().GetEnumerator();

                while (enumerator.MoveNext())
                    list.Add(enumerator.Current);

                return list;
            }
        }

    }
}
