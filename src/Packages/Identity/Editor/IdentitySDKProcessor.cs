namespace Openfort.OpenfortSDK.Editor
{
    class IdentitySDKProcessor : CommonSDKProcessorBase
    {
        protected override string GetDisplayName()
        {
            return "Identity";
        }

        protected override string GetPackageName()
        {
            return "com.portal.identity";
        }

        protected override string GetResourcesRelativePath()
        {
            return "Runtime/Resources";
        }
    }
}
