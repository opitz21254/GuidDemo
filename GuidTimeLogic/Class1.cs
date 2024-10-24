using System.Globalization;

namespace GuidTimeLogic;

public class Playground
{
    public TimeSpan DoStuff(int iterations)
    {
        Guid[] data = new Guid[iterations];
        for (int i = 0; i < iterations; i++)
        {
            data[i] = Guid.NewGuid();
        }
        for(int i = 0; i < iterations; i++)
        {
            for(int j = i+1; j < iterations; j++)
            if(data[i] == data[j]){
                throw new Exception($"Duplicate found at i:");
            }

        }
    }
}