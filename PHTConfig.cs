using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTProject
{
    public static class PHTConfig
    {
        public static LoginWindow loginWindow { get; set; }
        public static SignUpWindow signUpWindow { get; set; }
        public static HomePageWindow homePageWindow { get; set; }
        public  static DailyHealthMetrixEntryWindow dailyHealthMetrixEntryWindow { get; set; }
        public  static DeviceIntgrationWindow deviceIntgrationWindow { get; set; }
        public  static HealthGoalsWindow healthGoalsWindow { get; set; }
        public  static HealthHistoryWindow healthHistoryWindow { get; set; }
        public static HealthInsightWindow healthInsightWindow { get; set; }
        public  static ProfileSettingsWindow profileSettingsWindow { get; set; }
        public static UserDashBoardWindow userDashBoardWindow { get; set; }
        public static ContactSupportWindow contactSupportWindow { get; set; }

        static PHTConfig() 
        {
            loginWindow = new LoginWindow();
            signUpWindow = new SignUpWindow();
            homePageWindow = new HomePageWindow();
            dailyHealthMetrixEntryWindow = new DailyHealthMetrixEntryWindow();
            deviceIntgrationWindow = new DeviceIntgrationWindow();
            healthGoalsWindow = new HealthGoalsWindow();
            healthHistoryWindow = new HealthHistoryWindow();
            healthInsightWindow = new HealthInsightWindow();
            profileSettingsWindow = new ProfileSettingsWindow();
            userDashBoardWindow = new UserDashBoardWindow();
            contactSupportWindow = new ContactSupportWindow();
        }
    }
}
