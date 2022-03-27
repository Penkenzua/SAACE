namespace Accounting_for_refueling__printers
{
    class NameActiveForm
    {
        public static string NameForm = "";
        public static string NameTable = "";
        public static string NameIdTable = "";
        public static void Update(string name)
        {
            switch (name)
            {
                case "Account":
                    FormMainMenu.SelfRef.UpdateAccount();
                    break;
                case "Cartridge":
                    FormMainMenu.SelfRef.UpdateCartrdige();
                    break;
                case "CPU":
                    FormMainMenu.SelfRef.UpdateCPU();
                    break;
                case "GPU":
                    FormMainMenu.SelfRef.UpdateGPU();
                    break;
                case "Monitor":
                    FormMainMenu.SelfRef.UpdateMonitor();
                    break;
                case "OC":
                    FormMainMenu.SelfRef.UpdateOC();
                    break;
                case "PC":
                    FormMainMenu.SelfRef.UpdatePC();
                    break;
                case "Breaking":
                    FormMainMenu.SelfRef.UpdateBreaking();
                    break;
                case "Printer":
                    FormMainMenu.SelfRef.UpdatePrinter();
                    break;
                case "RAM":
                    FormMainMenu.SelfRef.UpdateRAM();
                    break;
                case "Storage_device":
                    FormMainMenu.SelfRef.UpdateStorageDevice();
                    break;
            }
        }
    }
}
