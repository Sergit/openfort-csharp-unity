using Openfort.OpenfortSDK.Editor;

namespace Portal.Identity.Editor
{
    class IdentitySDKProcessor : CommonSDKProcessorBase
    {
        protected override string GetDisplayName()
        {
            return IdentitySDK.DISPLAY_NAME;
        }

        protected override string GetPackageName()
        {
            return IdentitySDK.PACKAGE_NAME;
        }

        protected override string GetResourcesRelativePath()
        {
            return IdentitySDK.RESOURCES_RELATIVE_PATH;
        }

        protected override string GetDataRelativePath()
        {
            return IdentitySDK.DATA_RELATIVE_PATH;
        }
    }
}
