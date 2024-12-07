namespace Openfort.OpenfortSDK.Editor
{
    class OpenfortSDKAndroidProcessor : CommonSDKProcessorBase
    {
        protected override string GetDisplayName()
        {
            return "OpenfortSDK";
        }

        protected override string GetPackageName()
        {
            return "com.openfort.sdk";
        }

        protected override string GetResourcesRelativePath()
        {
            return "Runtime/Resources";
        }
    }
}
