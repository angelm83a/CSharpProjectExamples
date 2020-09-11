namespace ReduceStringRemovingConsecutiveCharacters
{
    /// <summary>
    /// Class to receive the character and frequency
    /// </summary>
    public class Entity
    {
        public char character;
        public int frequency;
        public Entity(char p, int q)
        {
            character = p;
            frequency = q;
        }
    }
}
