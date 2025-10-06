using System;

namespace myworld_memeto

{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo nhân vật
            GameCharacter hero = new GameCharacter();
            hero.Level = 1;
            hero.Health = 100;
            hero.Position = "Village";

            // Lưu trạng thái ban đầu
            GameHistory history = new GameHistory();
            history.Checkpoint = hero.SaveState();

            Console.WriteLine("\n=== Hero tiếp tục phiêu lưu ===\n");

            // Thay đổi trạng thái
            hero.Level = 2;
            hero.Health = 50;
            hero.Position = "Dark Forest";

            // Nhân vật thua trận -> quay về checkpoint
            Console.WriteLine("\n=== Hero bị đánh bại! Khôi phục lại checkpoint ===\n");
            hero.RestoreState(history.Checkpoint);

            Console.ReadKey();
        }
    }
}