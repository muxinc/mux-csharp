using System;
using System.Collections.Generic;
using Xunit;

using Mux.Csharp.Sdk.Api;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;
using System.Threading;

namespace Mux.Csharp.Sdk.Test.Video
{
    public class ExerciseAssets
    {
        [Fact]
        public void Exercise()
        {
            Console.WriteLine("starting tests ✅");
            var config = TestHelpers.BuildApiConfiguration();
            Console.WriteLine("creating assets api");
            var assets = new AssetsApi(config);
            Console.WriteLine("creating playback id api");
            var playbackIds = new PlaybackIDApi(config);

#region Asset creation
            var inputA = new InputSettings(
                url: "https://storage.googleapis.com/muxdemofiles/mux-video-intro.mp4"
            );
            var inputB = new InputSettings(
                url: "https://tears-of-steel-subtitles.s3.amazonaws.com/tears-fr.vtt",
                type: InputSettings.TypeEnum.Text,
                textType: InputSettings.TextTypeEnum.Subtitles,
                name: "French",
                languageCode: "fr",
                closedCaptions: false
            );

            var car = new CreateAssetRequest(
                input: new List<InputSettings>() { inputA }
            );

            Console.WriteLine("creating an asset");
            var createResponse = assets.CreateAsset(car);
            Assert.NotNull(createResponse);

            var assetId = createResponse.Data.Id;
            Assert.NotNull(assetId);

            Console.WriteLine("create-asset OK ✅");

            var assetsListResponse = assets.ListAssets(limit: 50, page: 0);
            Assert.NotNull(assetsListResponse);
            Assert.Equal(assetId, assetsListResponse.Data[0].Id);

            AssetResponse asset = null;
            do
            {
                asset = assets.GetAsset(assetId);

                Assert.NotNull(asset);
                Assert.Equal(assetId, asset.Data.Id);

                if (asset.Data.Status != Asset.StatusEnum.Ready) {
                    Console.WriteLine(" - waiting for asset to be ready...");
                    Thread.Sleep(2000);
                }
            }
            while (asset == null || asset.Data.Status != Asset.StatusEnum.Ready);
            Console.WriteLine("get-asset OK ✅");
            
            var assetInputInfo = assets.GetAssetInputInfo(assetId);
            Assert.NotNull(assetInputInfo);
            Assert.NotNull(assetInputInfo.Data);
            Console.WriteLine("get-asset-input-info OK ✅");
#endregion

#region Clipping
            var clipInput = new InputSettings(
                url: $"mux://assets/{assetId}",
                startTime: 0.0,
                endTime: 0.5
            );
            var clipRequest = new CreateAssetRequest(input: new List<InputSettings>() { clipInput });
            var clipResponse = assets.CreateAsset(clipRequest);
            var clipAssetId = clipResponse.Data.Id;
            Assert.NotNull(clipAssetId);

            AssetResponse clipAsset = null;
            do
            {
                clipAsset = assets.GetAsset(clipAssetId);

                Assert.NotNull(clipAsset);
                Assert.Equal(clipAssetId, clipAsset.Data.Id);

                if (clipAsset.Data.Status != Asset.StatusEnum.Ready) {
                    Console.WriteLine(" - waiting for clipped asset to be ready...");
                    Thread.Sleep(2000);
                }
            }
            while (clipAsset == null || clipAsset.Data.Status != Asset.StatusEnum.Ready);
#endregion

            // TODO: do the rest of ExerciseAssets

#region Deletion/cleanup
            assets.DeleteAsset(assetId);
            Assert.Throws<ApiException>(() => {
                assets.GetAsset(assetId);
            });

            assets.DeleteAsset(clipAssetId);
            Console.WriteLine("delete-asset OK ✅");
#endregion
        }
    }
}