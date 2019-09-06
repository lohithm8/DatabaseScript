using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyProjectBAL;
using System.Configuration;
using System.Data;

namespace ProjectDAL
{
    public class MyDAL
    {

        //EventInsert
        public bool CreateEvent(Event ed)
        {
            // bool sts = false;
            //bool sts = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Event_Table values(@eve_id,@eve_name,@description,@priority,@status)", cn);
            cmd.Parameters.AddWithValue("@eve_id", ed.Eve_id);
            cmd.Parameters.AddWithValue("@eve_name", ed.Eve_name);
            cmd.Parameters.AddWithValue("@description", ed.Description);
            cmd.Parameters.AddWithValue("@priority", ed.Priority);
            cmd.Parameters.AddWithValue("@status", ed.Status);
            //cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool status = false;
            if (i > 0)
            {
                status = true;
            }
            cn.Close();
            return status;
        }

        //CourseInsert
        public bool CreateCourse(Course cd)
        {
            //bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Course_Table values(@course_id,@course_name,@speaker_id,@cost,@course_desc,@category,@promo_code)", cn);
            cmd.Parameters.AddWithValue("@course_id", cd.Course_id);
            cmd.Parameters.AddWithValue("@course_name", cd.Course_name);
            cmd.Parameters.AddWithValue("@speaker_id", cd.Speaker_id);
            cmd.Parameters.AddWithValue("@cost", cd.Cost);
            cmd.Parameters.AddWithValue("@course_desc", cd.Course_desc);
            cmd.Parameters.AddWithValue("@category", cd.Category);
            cmd.Parameters.AddWithValue("@promo_code", cd.Promo_code);


            //cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool sts = false;
            if (i > 0)
            {
                sts = true;
            }
            cn.Close();
            return sts;

        }

        //SpeakerInsert
        public bool CreateSpeaker(Speaker sp)
        {
            //bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Speaker_Table values(@speaker_id,@speaker_name,@address,@contact,@key_skill,@semail)", cn);
            cmd.Parameters.AddWithValue("@speaker_id", sp.Speaker_id);
            cmd.Parameters.AddWithValue("@speaker_name", sp.Speaker_name);
            cmd.Parameters.AddWithValue("@address", sp.Address);
            cmd.Parameters.AddWithValue("@contact", sp.Contact);
            cmd.Parameters.AddWithValue("@key_skill", sp.Key_skill);
            cmd.Parameters.AddWithValue("@semail", sp.Semail);
            //cmd.Parameters.AddWithValue("@promo_code", cd.Promo_code);


            //cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool stas = false;
            if (i > 0)
            {
                stas = true;
            }
            cn.Close();
            return stas;
        }

        //venueinsert
        public bool CreateVenue(Venue ve)
        {
            //bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Venue_Table values(@venue_id,@venue_name,@start_date,@end_date,@class_size,@location)", cn);
            cmd.Parameters.AddWithValue("@venue_id", ve.Venue_id);
            cmd.Parameters.AddWithValue("@venue_name", ve.Venue_name);
            cmd.Parameters.AddWithValue("@start_date", ve.Start_date);
            cmd.Parameters.AddWithValue("@end_date", ve.End_date);
            cmd.Parameters.AddWithValue("@class_size", ve.class_size);
            cmd.Parameters.AddWithValue("@location", ve.Location);
            //cmd.Parameters.AddWithValue("@promo_code", cd.Promo_code);


            //cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool stats = false;
            if (i > 0)
            {
                stats = true;
            }
            cn.Close();
            return stats;
        }
        //participantInsert
        public bool createParticipant(Participant pt)
        {
            SqlConnection cn = new SqlConnection
                   (ConfigurationManager.ConnectionStrings
                   ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Participant_Table values(@par_id,@first_name,@mid_name,@last_name,@dob,@gender,@mobile,@email)", cn);
            cmd.Parameters.AddWithValue("@par_id", pt.Par_id);
            cmd.Parameters.AddWithValue("@first_name", pt.First_name);
            cmd.Parameters.AddWithValue("@mid_name", pt.Mid_name);
            cmd.Parameters.AddWithValue("@last_name", pt.Last_name);
            cmd.Parameters.AddWithValue("@dob", pt.dob);
            cmd.Parameters.AddWithValue("@gender", pt.Gender);
            cmd.Parameters.AddWithValue("@mobile", pt.Mobile);
            cmd.Parameters.AddWithValue("@email", pt.email);
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool stats = false;
            if (i > 0)
            {
                stats = true;
            }
            cn.Close();
            return stats;
        }
        public bool UpdateEvent(Event ed)
        {
            //bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_UpdateEvent2", cn);
            cmd.Parameters.AddWithValue("@eve_name",ed.Eve_name);
            cmd.Parameters.AddWithValue("@description", ed.Description);
            cmd.Parameters.AddWithValue("@priority", ed.Priority);
            cmd.Parameters.AddWithValue("@status", ed.Status);
            cmd.Parameters.AddWithValue("@eve_id", ed.Eve_id);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool states = false;
            if (i <=1)
            {
                states = true;
            }
            cn.Close();
            return states;
        }
        public bool UpdateVenue(Venue ve)
        {
            //bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("update Venue_Table set venue_name=@venue_name,start_date=@start_date,end_date=@end_date,class_size=@class_size,location=@location", cn);
            cmd.Parameters.AddWithValue("@venue_name", ve.Venue_name);
            cmd.Parameters.AddWithValue("@start_date", ve.Start_date);
            cmd.Parameters.AddWithValue("@end_date", ve.End_date);
            cmd.Parameters.AddWithValue("@class_size", ve.class_size);
            cmd.Parameters.AddWithValue("@location", ve.Location);
            //cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool states = false;
            if (i <= 1)
            {
                states = true;
            }
            cn.Close();
            return states;
        }
        public bool UpdateCourse(Course ce)
        {
            //bool status = false;
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("update Course_Table set course_name=@course_name,cost=@cost,course_desc=@course_desc,category=@category,promo_code=@promo_code", cn);
            cmd.Parameters.AddWithValue("@course_id", ce.Course_id);
            cmd.Parameters.AddWithValue("@course_name", ce.Course_name);
            cmd.Parameters.AddWithValue("@cost", ce.Cost);
            cmd.Parameters.AddWithValue("@course_desc", ce.Course_desc);
            cmd.Parameters.AddWithValue("@category", ce.Category);
            cmd.Parameters.AddWithValue("@promo_code", ce.Promo_code);
            //cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int i = cmd.ExecuteNonQuery();
            bool states = false;
            if (i <= 1)
            {
                states = true;
            }
            cn.Close();
            return states;
        }
        public List<Course> ShowCourseList()
        {
            List<Course> coulist = new List<Course>();
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            string str = "select * from Course_Table";
            SqlCommand cmd = new SqlCommand(str, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Course c = new Course();
                c.Course_id = Convert.ToInt32(dr[0]);
                c.Course_name = dr[1].ToString();
                c.Speaker_id = Convert.ToInt32(dr[2]);
                c.Cost = Convert.ToInt32(dr[3]);
                c.Course_desc = dr[4].ToString();
                c.Category= dr[4].ToString();
                c.Promo_code= dr[5].ToString();
                coulist.Add(c);

            }
            cn.Close();
            return coulist;

        }
        public List<Participant> ShowPartiList()
        {
            List<Participant> parlist = new List<Participant>();
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["AdminDB"].ConnectionString);
            string str = "select * from Participant_Table";
            SqlCommand cmd = new SqlCommand(str, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Participant p = new Participant();
                p.Par_id= Convert.ToInt32((dr[0]).ToString());
                p.First_name = dr[1].ToString();
                p.Mid_name = dr[2].ToString();
                p.Last_name = dr[3].ToString();
                p.dob = Convert.ToDateTime(dr[4]);
                p.Gender = dr[5].ToString();
                p.Mobile = Convert.ToInt32(dr[6]);
                p.email = dr[7].ToString();
                parlist.Add(p);
            }
            cn.Close();
            return parlist;

        }
    }
}

