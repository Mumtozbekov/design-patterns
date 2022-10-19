using Adapter.Classes;
using Adapter.Interfaces;

namespace Adapter.Adapters
{
    internal class WildDogAdapter : ILion
    {
        private WildDog mDog;
        public WildDogAdapter(WildDog dog)
        {
            this.mDog = dog;
        }
        public void Roar()
        {
            mDog.Bark();
        }
    }
}
