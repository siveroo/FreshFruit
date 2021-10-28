using System.Collections.Generic;
using System.Linq;
using FreshFruit.model;

namespace FreshFruit.controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;
        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }
        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("Yey, berhasil ditambahkan");
            }
        }
        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }
        public void removeFruit(Fruit fruit)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.name)
                {
                    bucket.remove(itemPosition);
                    eventListener.onSucceed("Yey, berhasil dihapus");
                }
            }
        }

        public void clearFruit()
        {
            int len = bucket.countItems();
            if (len == 0)
            {
                eventListener.onFailed("Keranjang kosong!");
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    bucket.remove(0);
                }
                eventListener.onSucceed("Yey, berhasil mengosongkan keranjang!");
            }
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
