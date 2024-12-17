namespace Openfort.OpenfortSDK.Editor
{
    class OpenfortSDKProcessor : CommonSDKProcessorBase
    {
        protected override string GetDisplayName()
        {
            return OpenfortSDK.DISPLAY_NAME;
        }

        protected override string GetPackageName()
        {
            return OpenfortSDK.PACKAGE_NAME;
        }

        protected override string GetResourcesRelativePath()
        {
            return OpenfortSDK.RESOURCES_RELATIVE_PATH;
        }

        protected override string GetDataRelativePath()
        {
            return OpenfortSDK.DATA_RELATIVE_PATH;
        }
    }
}
