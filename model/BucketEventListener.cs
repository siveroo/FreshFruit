namespace FreshFruit.model
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}
