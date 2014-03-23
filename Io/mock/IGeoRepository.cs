using System;
namespace mock
{
    public interface IGeoRepository
    {
        void Add(string naDzialki, double x, double y, double minX, double minY, double maxX, double maxY);
    }
}
