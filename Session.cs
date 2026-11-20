
namespace KemasProject
{
    public static class Session
    {
        public static int UserId { get; set; }

        public static string Nama { get; set; }

        public static string Username { get; set; }

        public static string Status { get; set; }

        public static bool IsLoggedIn
        {
            get
            {
                return UserId > 0;
            }
        }

        public static void StartSession(
            int userId,
            string nama,
            string username,
            string status)
        {
            UserId = userId;
            Nama = nama;
            Username = username;
            Status = status;
        }

        public static void ClearSession()
        {
            UserId = 0;
            Nama = null;
            Username = null;
            Status = null;
        }
    }
}
