// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("gzGykYO+tbqZNfs1RL6ysrK2s7BDo0XupsTYOdwBoxsaBq63h8aJ9B4nyKzInkJXzvw1+vWn3Y+h8FFqMbK8s4MxsrmxMbKysyR2NZJad0UbYIbl6f+0iYAZ5N6pb18/nyHuwfgwRIcy2z0FGsOxps5LlgzOQ6nXQmSs6VVE/hurQ1N88bfvhJlHEUyZbh2j0FNzr4337zOtiQNPxnVNjl0DttFBRuQ5sojs/LMWsnINBqjcs5AC2DNbgI8xAsyXUEh2RHCm+RTvDcm90kJQ4yfPf2WIQRsUvXyk0lLrgH49OoD/wjavGXhZWYDxl+j02ZgWXoSeQnGhXRteGHuV3m1aLqajZ78UfrRSI56+TUkJqv7seiQXUHTIpQN2bD/EgrGwsrOy");
        private static int[] order = new int[] { 0,10,12,10,8,10,6,11,9,11,10,13,12,13,14 };
        private static int key = 179;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
