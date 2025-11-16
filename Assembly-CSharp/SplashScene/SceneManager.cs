using System;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AssetHandleUtility;
using GamePlatform.Systems;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Omt.Net.Http;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Video;

namespace SplashScene
{
	// Token: 0x02000037 RID: 55
	public class SceneManager : MonoBehaviour
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x000B0938 File Offset: 0x000AEB38
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplashScene", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_loadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "loadScene");
			SceneManager.NativeFieldInfoPtr_logoTransitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "logoTransitionDuration");
			SceneManager.NativeFieldInfoPtr_splashVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "splashVisuals");
			SceneManager.NativeFieldInfoPtr_syncWithSteamVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "syncWithSteamVisual");
			SceneManager.NativeFieldInfoPtr_video = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "video");
			SceneManager.NativeFieldInfoPtr_videoRenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "videoRenderTexture");
			SceneManager.NativeFieldInfoPtr_versionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "versionData");
			SceneManager.NativeFieldInfoPtr_TMP_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "TMP_Settings");
			SceneManager.NativeFieldInfoPtr_videoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "videoPlayer");
			SceneManager.NativeFieldInfoPtr_requirdTesterLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "requirdTesterLogin");
			SceneManager.NativeFieldInfoPtr_cancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "cancellationTokenSource");
			SceneManager.NativeFieldInfoPtr_userName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "userName");
			SceneManager.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "password");
			SceneManager.NativeFieldInfoPtr_errorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "errorMessage");
			SceneManager.NativeFieldInfoPtr_deviceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "deviceID");
			SceneManager.NativeFieldInfoPtr_INCORRECT_USERNAME_OR_PASSWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "INCORRECT_USERNAME_OR_PASSWORD");
			SceneManager.NativeFieldInfoPtr_MAX_DEVICE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "MAX_DEVICE_COUNT");
			SceneManager.NativeFieldInfoPtr_SERVER_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "SERVER_ERROR");
			SceneManager.NativeFieldInfoPtr_m_HttpRequester = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_HttpRequester");
			SceneManager.NativeMethodInfoPtr_get_CurrentConsoleMode_Public_Static_get_ConsoleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664100);
			SceneManager.NativeMethodInfoPtr_get_EnableDebugCosole_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664101);
			SceneManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664102);
			SceneManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664103);
			SceneManager.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664104);
			SceneManager.NativeMethodInfoPtr_GetLoginResultCallback_Private_Void_HttpResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664105);
			SceneManager.NativeMethodInfoPtr_OnLoginFailed_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664106);
			SceneManager.NativeMethodInfoPtr_LoadLoginResultCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664107);
			SceneManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664108);
			SceneManager.NativeMethodInfoPtr_PreInitAllSplashGUIs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664109);
			SceneManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664110);
			SceneManager.NativeMethodInfoPtr_OnDisplayingSplash_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664111);
			SceneManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664112);
			SceneManager.NativeMethodInfoPtr_DisplayImageSession_Private_UniTask_CanvasGroup_Single_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664113);
			SceneManager.NativeMethodInfoPtr_DisplayVideoSession_Private_UniTask_UniTask_1_IAssetHandle_1_VideoClip_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664114);
			SceneManager.NativeMethodInfoPtr_ClearRenderTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664115);
			SceneManager.NativeMethodInfoPtr_DisplayIn_Private_UniTask_CanvasGroup_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664116);
			SceneManager.NativeMethodInfoPtr_UpdateVisualAlpha_Private_Void_CanvasGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664117);
			SceneManager.NativeMethodInfoPtr_DisplayOut_Private_UniTask_CanvasGroup_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664118);
			SceneManager.NativeMethodInfoPtr_LoadScene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664119);
			SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664120);
			SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664121);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000B0C9C File Offset: 0x000AEE9C
		public unsafe static ConsoleMode CurrentConsoleMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25581, XrefRangeEnd = 25582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_CurrentConsoleMode_Public_Static_get_ConsoleMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000B0CCC File Offset: 0x000AEECC
		public unsafe static bool EnableDebugCosole
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_EnableDebugCosole_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000B0CFC File Offset: 0x000AEEFC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000B0D30 File Offset: 0x000AEF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25881, XrefRangeEnd = 25964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000B0D64 File Offset: 0x000AEF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25964, XrefRangeEnd = 26100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000B0D98 File Offset: 0x000AEF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26100, XrefRangeEnd = 26116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLoginResultCallback(HttpResponse httpResponseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(httpResponseMessage));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetLoginResultCallback_Private_Void_HttpResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000B0DE0 File Offset: 0x000AEFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26116, XrefRangeEnd = 26124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoginFailed(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnLoginFailed_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000B0E24 File Offset: 0x000AF024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26124, XrefRangeEnd = 26135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLoginResultCallback(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadLoginResultCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000B0E68 File Offset: 0x000AF068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26135, XrefRangeEnd = 26163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000B0E9C File Offset: 0x000AF09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26163, XrefRangeEnd = 26180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreInitAllSplashGUIs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_PreInitAllSplashGUIs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000B0ED0 File Offset: 0x000AF0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26180, XrefRangeEnd = 26212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000B0F04 File Offset: 0x000AF104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26212, XrefRangeEnd = 26218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnDisplayingSplash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnDisplayingSplash_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000B0F3C File Offset: 0x000AF13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26218, XrefRangeEnd = 26221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000B0F70 File Offset: 0x000AF170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26229, RefRangeEnd = 26230, XrefRangeStart = 26221, XrefRangeEnd = 26229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask DisplayImageSession(CanvasGroup canvasGroup, float displayDuration, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayDuration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_DisplayImageSession_Private_UniTask_CanvasGroup_Single_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000B0FE0 File Offset: 0x000AF1E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26238, RefRangeEnd = 26239, XrefRangeStart = 26230, XrefRangeEnd = 26238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask DisplayVideoSession(UniTask<IAssetHandle<VideoClip>> loadingAssetHandle, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadingAssetHandle));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_DisplayVideoSession_Private_UniTask_UniTask_1_IAssetHandle_1_VideoClip_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000B1044 File Offset: 0x000AF244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26239, XrefRangeEnd = 26243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRenderTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_ClearRenderTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000B1078 File Offset: 0x000AF278
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26251, RefRangeEnd = 26254, XrefRangeStart = 26243, XrefRangeEnd = 26251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask DisplayIn(CanvasGroup pair, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pair);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_DisplayIn_Private_UniTask_CanvasGroup_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000B10D8 File Offset: 0x000AF2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26254, XrefRangeEnd = 26256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisualAlpha(CanvasGroup image, float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UpdateVisualAlpha_Private_Void_CanvasGroup_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000B1128 File Offset: 0x000AF328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26264, RefRangeEnd = 26267, XrefRangeStart = 26256, XrefRangeEnd = 26264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask DisplayOut(CanvasGroup pair, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pair);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_DisplayOut_Private_UniTask_CanvasGroup_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000B1188 File Offset: 0x000AF388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26267, XrefRangeEnd = 26271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000B11BC File Offset: 0x000AF3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26271, XrefRangeEnd = 26284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26284, XrefRangeEnd = 26300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000054D3 File Offset: 0x000036D3
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000B1234 File Offset: 0x000AF434
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000054DC File Offset: 0x000036DC
		public unsafe AssetReference loadScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_loadScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_loadScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000B1264 File Offset: 0x000AF464
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000054FB File Offset: 0x000036FB
		public unsafe float logoTransitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_logoTransitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_logoTransitionDuration)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000B128C File Offset: 0x000AF48C
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00005516 File Offset: 0x00003716
		public unsafe Il2CppReferenceArray<SceneManager.SplashVisualPair> splashVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_splashVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SceneManager.SplashVisualPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_splashVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000B12BC File Offset: 0x000AF4BC
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00005535 File Offset: 0x00003735
		public unsafe CanvasGroup syncWithSteamVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_syncWithSteamVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_syncWithSteamVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000B12EC File Offset: 0x000AF4EC
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00005554 File Offset: 0x00003754
		public unsafe CanvasGroup video
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_video);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_video), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000B131C File Offset: 0x000AF51C
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00005573 File Offset: 0x00003773
		public unsafe RenderTexture videoRenderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_videoRenderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_videoRenderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000B134C File Offset: 0x000AF54C
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00005592 File Offset: 0x00003792
		public unsafe TextAsset versionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_versionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_versionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x000B137C File Offset: 0x000AF57C
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x000055B1 File Offset: 0x000037B1
		public unsafe AssetReference TMP_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_TMP_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_TMP_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000B13AC File Offset: 0x000AF5AC
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x000055D0 File Offset: 0x000037D0
		public unsafe VideoPlayer videoPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_videoPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_videoPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000B13DC File Offset: 0x000AF5DC
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000055EF File Offset: 0x000037EF
		public unsafe bool requirdTesterLogin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_requirdTesterLogin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_requirdTesterLogin)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000B1404 File Offset: 0x000AF604
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x0000560A File Offset: 0x0000380A
		public unsafe CancellationTokenSource cancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_cancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_cancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000B1434 File Offset: 0x000AF634
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00005629 File Offset: 0x00003829
		public unsafe string userName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_userName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_userName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x000B145C File Offset: 0x000AF65C
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00005648 File Offset: 0x00003848
		public unsafe string password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000B1484 File Offset: 0x000AF684
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00005667 File Offset: 0x00003867
		public unsafe string errorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_errorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_errorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000B14AC File Offset: 0x000AF6AC
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00005686 File Offset: 0x00003886
		public unsafe string deviceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_deviceID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_deviceID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000B14D4 File Offset: 0x000AF6D4
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000056A5 File Offset: 0x000038A5
		public unsafe static string INCORRECT_USERNAME_OR_PASSWORD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_INCORRECT_USERNAME_OR_PASSWORD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_INCORRECT_USERNAME_OR_PASSWORD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000B14F4 File Offset: 0x000AF6F4
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x000056B7 File Offset: 0x000038B7
		public unsafe static string MAX_DEVICE_COUNT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_MAX_DEVICE_COUNT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_MAX_DEVICE_COUNT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000B1514 File Offset: 0x000AF714
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000056C9 File Offset: 0x000038C9
		public unsafe static string SERVER_ERROR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_SERVER_ERROR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_SERVER_ERROR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000B1534 File Offset: 0x000AF734
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000056DB File Offset: 0x000038DB
		public unsafe HttpRequester m_HttpRequester
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_HttpRequester);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequester>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_HttpRequester), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_loadScene;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_logoTransitionDuration;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_splashVisuals;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_syncWithSteamVisual;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_video;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_videoRenderTexture;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_versionData;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_TMP_Settings;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_videoPlayer;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_requirdTesterLogin;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_cancellationTokenSource;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_userName;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_password;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_errorMessage;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_deviceID;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_INCORRECT_USERNAME_OR_PASSWORD;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DEVICE_COUNT;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_SERVER_ERROR;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_m_HttpRequester;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentConsoleMode_Public_Static_get_ConsoleMode_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableDebugCosole_Public_Static_get_Boolean_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_GetLoginResultCallback_Private_Void_HttpResponse_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_OnLoginFailed_Private_Void_Exception_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_LoadLoginResultCallback_Private_Void_String_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_PreInitAllSplashGUIs_Private_Void_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_OnDisplayingSplash_Private_UniTask_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_DisplayImageSession_Private_UniTask_CanvasGroup_Single_CancellationToken_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_DisplayVideoSession_Private_UniTask_UniTask_1_IAssetHandle_1_VideoClip_CancellationToken_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderTexture_Private_Void_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_DisplayIn_Private_UniTask_CanvasGroup_CancellationToken_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisualAlpha_Private_Void_CanvasGroup_Single_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_DisplayOut_Private_UniTask_CanvasGroup_CancellationToken_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Private_Void_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004B9 RID: 1209
		[Serializable]
		public sealed class SplashVisualPair : ValueType
		{
			// Token: 0x06007F82 RID: 32642 RVA: 0x00243A34 File Offset: 0x00241C34
			// Note: this type is marked as 'beforefieldinit'.
			static SplashVisualPair()
			{
				Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "SplashVisualPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr);
				SceneManager.SplashVisualPair.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, "visual");
				SceneManager.SplashVisualPair.NativeFieldInfoPtr_mustCompleteBeforeFirstScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, "mustCompleteBeforeFirstScene");
				SceneManager.SplashVisualPair.NativeFieldInfoPtr_hideInSwitchPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, "hideInSwitchPlatform");
				SceneManager.SplashVisualPair.NativeFieldInfoPtr_video = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, "video");
				SceneManager.SplashVisualPair.NativeFieldInfoPtr_displayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, "displayDuration");
			}

			// Token: 0x06007F83 RID: 32643 RVA: 0x000449F4 File Offset: 0x00042BF4
			public SplashVisualPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007F84 RID: 32644 RVA: 0x000449FD File Offset: 0x00042BFD
			public SplashVisualPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr))
			{
			}

			// Token: 0x17002B0A RID: 11018
			// (get) Token: 0x06007F85 RID: 32645 RVA: 0x00243AC4 File Offset: 0x00241CC4
			// (set) Token: 0x06007F86 RID: 32646 RVA: 0x00044A0F File Offset: 0x00042C0F
			public unsafe CanvasGroup visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B0B RID: 11019
			// (get) Token: 0x06007F87 RID: 32647 RVA: 0x00243AF4 File Offset: 0x00241CF4
			// (set) Token: 0x06007F88 RID: 32648 RVA: 0x00044A2E File Offset: 0x00042C2E
			public unsafe bool mustCompleteBeforeFirstScene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_mustCompleteBeforeFirstScene);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_mustCompleteBeforeFirstScene)) = value;
				}
			}

			// Token: 0x17002B0C RID: 11020
			// (get) Token: 0x06007F89 RID: 32649 RVA: 0x00243B1C File Offset: 0x00241D1C
			// (set) Token: 0x06007F8A RID: 32650 RVA: 0x00044A49 File Offset: 0x00042C49
			public unsafe bool hideInSwitchPlatform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_hideInSwitchPlatform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_hideInSwitchPlatform)) = value;
				}
			}

			// Token: 0x17002B0D RID: 11021
			// (get) Token: 0x06007F8B RID: 32651 RVA: 0x00243B44 File Offset: 0x00241D44
			// (set) Token: 0x06007F8C RID: 32652 RVA: 0x00044A64 File Offset: 0x00042C64
			public unsafe AssetReference video
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_video);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_video), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B0E RID: 11022
			// (get) Token: 0x06007F8D RID: 32653 RVA: 0x00243B74 File Offset: 0x00241D74
			// (set) Token: 0x06007F8E RID: 32654 RVA: 0x00044A83 File Offset: 0x00042C83
			public unsafe float displayDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_displayDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.SplashVisualPair.NativeFieldInfoPtr_displayDuration)) = value;
				}
			}

			// Token: 0x040053C8 RID: 21448
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x040053C9 RID: 21449
			private static readonly IntPtr NativeFieldInfoPtr_mustCompleteBeforeFirstScene;

			// Token: 0x040053CA RID: 21450
			private static readonly IntPtr NativeFieldInfoPtr_hideInSwitchPlatform;

			// Token: 0x040053CB RID: 21451
			private static readonly IntPtr NativeFieldInfoPtr_video;

			// Token: 0x040053CC RID: 21452
			private static readonly IntPtr NativeFieldInfoPtr_displayDuration;
		}

		// Token: 0x020004BA RID: 1210
		[StructLayout(2)]
		public struct LoginResultDataModel
		{
			// Token: 0x06007F8F RID: 32655 RVA: 0x00243B9C File Offset: 0x00241D9C
			// Note: this type is marked as 'beforefieldinit'.
			static LoginResultDataModel()
			{
				Il2CppClassPointerStore<SceneManager.LoginResultDataModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "LoginResultDataModel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.LoginResultDataModel>.NativeClassPtr);
				SceneManager.LoginResultDataModel.NativeFieldInfoPtr__ResultCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.LoginResultDataModel>.NativeClassPtr, "<ResultCode>k__BackingField");
				SceneManager.LoginResultDataModel.NativeMethodInfoPtr_get_ResultCode_Public_get_LoginResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.LoginResultDataModel>.NativeClassPtr, 100664122);
				SceneManager.LoginResultDataModel.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_LoginResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.LoginResultDataModel>.NativeClassPtr, 100664123);
			}

			// Token: 0x17002B0F RID: 11023
			// (get) Token: 0x06007F90 RID: 32656 RVA: 0x00243C04 File Offset: 0x00241E04
			// (set) Token: 0x06007F91 RID: 32657 RVA: 0x00243C34 File Offset: 0x00241E34
			public unsafe SceneManager.LoginResultDataModel.LoginResult ResultCode
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.LoginResultDataModel.NativeMethodInfoPtr_get_ResultCode_Public_get_LoginResult_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25101, RefRangeEnd = 25115, XrefRangeStart = 25101, XrefRangeEnd = 25101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.LoginResultDataModel.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_LoginResult_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007F92 RID: 32658 RVA: 0x00044A9E File Offset: 0x00042C9E
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneManager.LoginResultDataModel>.NativeClassPtr, ref this));
			}

			// Token: 0x040053CD RID: 21453
			private static readonly IntPtr NativeFieldInfoPtr__ResultCode_k__BackingField;

			// Token: 0x040053CE RID: 21454
			private static readonly IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_LoginResult_0;

			// Token: 0x040053CF RID: 21455
			private static readonly IntPtr NativeMethodInfoPtr_set_ResultCode_Public_set_Void_LoginResult_0;

			// Token: 0x040053D0 RID: 21456
			[FieldOffset(0)]
			public SceneManager.LoginResultDataModel.LoginResult _ResultCode_k__BackingField;

			// Token: 0x02000FAB RID: 4011
			public enum LoginResult
			{
				// Token: 0x0400AEDE RID: 44766
				Succeed,
				// Token: 0x0400AEDF RID: 44767
				MismatchedUserNameOrPassword,
				// Token: 0x0400AEE0 RID: 44768
				DeviceUpToLimit
			}
		}

		// Token: 0x020004BB RID: 1211
		[ObfuscatedName("SplashScene.SceneManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007F93 RID: 32659 RVA: 0x00243C68 File Offset: 0x00241E68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr);
				SceneManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9");
				SceneManager.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__31_0");
				SceneManager.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__34_0");
				SceneManager.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__34_1");
				SceneManager.__c.NativeFieldInfoPtr___9__34_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__34_2");
				SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100664125);
				SceneManager.__c.NativeMethodInfoPtr__Start_b__31_0_Internal_Int32_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100664126);
				SceneManager.__c.NativeMethodInfoPtr__OnDisplayingSplash_b__34_0_Internal_Boolean_SplashVisualPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100664127);
				SceneManager.__c.NativeMethodInfoPtr__OnDisplayingSplash_b__34_1_Internal_SplashVisualPair_SplashVisualPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100664128);
				SceneManager.__c.NativeMethodInfoPtr__OnDisplayingSplash_b__34_2_Internal_ValueTuple_2_Boolean_UniTask_1_IAssetHandle_1_VideoClip_SplashVisualPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100664129);
			}

			// Token: 0x06007F94 RID: 32660 RVA: 0x00243D5C File Offset: 0x00241F5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F95 RID: 32661 RVA: 0x00243D98 File Offset: 0x00241F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25115, XrefRangeEnd = 25116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Start_b__31_0(Resolution x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__Start_b__31_0_Internal_Int32_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F96 RID: 32662 RVA: 0x00243DE4 File Offset: 0x00241FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25116, XrefRangeEnd = 25117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnDisplayingSplash_b__34_0(SceneManager.SplashVisualPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__OnDisplayingSplash_b__34_0_Internal_Boolean_SplashVisualPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F97 RID: 32663 RVA: 0x00243E38 File Offset: 0x00242038
			[CallerCount(0)]
			public unsafe SceneManager.SplashVisualPair _OnDisplayingSplash_b__34_1(SceneManager.SplashVisualPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__OnDisplayingSplash_b__34_1_Internal_SplashVisualPair_SplashVisualPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new SceneManager.SplashVisualPair(pointer);
			}

			// Token: 0x06007F98 RID: 32664 RVA: 0x00243E88 File Offset: 0x00242088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25117, XrefRangeEnd = 25123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<bool, UniTask<IAssetHandle<VideoClip>>> _OnDisplayingSplash_b__34_2(SceneManager.SplashVisualPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__OnDisplayingSplash_b__34_2_Internal_ValueTuple_2_Boolean_UniTask_1_IAssetHandle_1_VideoClip_SplashVisualPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<bool, UniTask<IAssetHandle<VideoClip>>>(pointer);
			}

			// Token: 0x06007F99 RID: 32665 RVA: 0x00044AB0 File Offset: 0x00042CB0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B10 RID: 11024
			// (get) Token: 0x06007F9A RID: 32666 RVA: 0x00243ED8 File Offset: 0x002420D8
			// (set) Token: 0x06007F9B RID: 32667 RVA: 0x00044AB9 File Offset: 0x00042CB9
			public unsafe static SceneManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B11 RID: 11025
			// (get) Token: 0x06007F9C RID: 32668 RVA: 0x00243F00 File Offset: 0x00242100
			// (set) Token: 0x06007F9D RID: 32669 RVA: 0x00044ACB File Offset: 0x00042CCB
			public unsafe static Func<Resolution, int> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Resolution, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B12 RID: 11026
			// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00243F28 File Offset: 0x00242128
			// (set) Token: 0x06007F9F RID: 32671 RVA: 0x00044ADD File Offset: 0x00042CDD
			public unsafe static Func<SceneManager.SplashVisualPair, bool> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SceneManager.SplashVisualPair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B13 RID: 11027
			// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x00243F50 File Offset: 0x00242150
			// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x00044AEF File Offset: 0x00042CEF
			public unsafe static Func<SceneManager.SplashVisualPair, SceneManager.SplashVisualPair> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SceneManager.SplashVisualPair, SceneManager.SplashVisualPair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B14 RID: 11028
			// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x00243F78 File Offset: 0x00242178
			// (set) Token: 0x06007FA3 RID: 32675 RVA: 0x00044B01 File Offset: 0x00042D01
			public unsafe static Func<SceneManager.SplashVisualPair, ValueTuple<bool, UniTask<IAssetHandle<VideoClip>>>> __9__34_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__34_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SceneManager.SplashVisualPair, ValueTuple<bool, UniTask<IAssetHandle<VideoClip>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__34_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040053D1 RID: 21457
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040053D2 RID: 21458
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x040053D3 RID: 21459
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x040053D4 RID: 21460
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x040053D5 RID: 21461
			private static readonly IntPtr NativeFieldInfoPtr___9__34_2;

			// Token: 0x040053D6 RID: 21462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040053D7 RID: 21463
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_0_Internal_Int32_Resolution_0;

			// Token: 0x040053D8 RID: 21464
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingSplash_b__34_0_Internal_Boolean_SplashVisualPair_0;

			// Token: 0x040053D9 RID: 21465
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingSplash_b__34_1_Internal_SplashVisualPair_SplashVisualPair_0;

			// Token: 0x040053DA RID: 21466
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingSplash_b__34_2_Internal_ValueTuple_2_Boolean_UniTask_1_IAssetHandle_1_VideoClip_SplashVisualPair_0;
		}

		// Token: 0x020004BC RID: 1212
		[ObfuscatedName("SplashScene.SceneManager+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x06007FA4 RID: 32676 RVA: 0x00243FA0 File Offset: 0x002421A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass33_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass33_0.NativeFieldInfoPtr_uniTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass33_0>.NativeClassPtr, "uniTask");
				SceneManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass33_0>.NativeClassPtr, 100664130);
				SceneManager.__c__DisplayClass33_0.NativeMethodInfoPtr__Init_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass33_0>.NativeClassPtr, 100664131);
			}

			// Token: 0x06007FA5 RID: 32677 RVA: 0x00244008 File Offset: 0x00242208
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FA6 RID: 32678 RVA: 0x00244044 File Offset: 0x00242244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25123, XrefRangeEnd = 25125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Init_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass33_0.NativeMethodInfoPtr__Init_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FA7 RID: 32679 RVA: 0x00044B13 File Offset: 0x00042D13
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B15 RID: 11029
			// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x00244078 File Offset: 0x00242278
			// (set) Token: 0x06007FA9 RID: 32681 RVA: 0x00044B1C File Offset: 0x00042D1C
			public UniTask uniTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass33_0.NativeFieldInfoPtr_uniTask);
					return new UniTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass33_0.NativeFieldInfoPtr_uniTask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040053DB RID: 21467
			private static readonly IntPtr NativeFieldInfoPtr_uniTask;

			// Token: 0x040053DC RID: 21468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040053DD RID: 21469
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__0_Internal_Void_0;
		}

		// Token: 0x020004BD RID: 1213
		[ObfuscatedName("SplashScene.SceneManager+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x06007FAA RID: 32682 RVA: 0x002440A8 File Offset: 0x002422A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass34_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr, "canContinue");
				SceneManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr, 100664132);
				SceneManager.__c__DisplayClass34_0.NativeMethodInfoPtr__OnDisplayingSplash_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr, 100664133);
				SceneManager.__c__DisplayClass34_0.NativeMethodInfoPtr__OnDisplayingSplash_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr, 100664134);
			}

			// Token: 0x06007FAB RID: 32683 RVA: 0x00244124 File Offset: 0x00242324
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FAC RID: 32684 RVA: 0x00244160 File Offset: 0x00242360
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDisplayingSplash_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass34_0.NativeMethodInfoPtr__OnDisplayingSplash_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FAD RID: 32685 RVA: 0x00244194 File Offset: 0x00242394
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnDisplayingSplash_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass34_0.NativeMethodInfoPtr__OnDisplayingSplash_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007FAE RID: 32686 RVA: 0x00044B4A File Offset: 0x00042D4A
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B16 RID: 11030
			// (get) Token: 0x06007FAF RID: 32687 RVA: 0x002441D0 File Offset: 0x002423D0
			// (set) Token: 0x06007FB0 RID: 32688 RVA: 0x00044B53 File Offset: 0x00042D53
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass34_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass34_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x040053DE RID: 21470
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x040053DF RID: 21471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040053E0 RID: 21472
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingSplash_b__3_Internal_Void_0;

			// Token: 0x040053E1 RID: 21473
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingSplash_b__4_Internal_Boolean_0;
		}

		// Token: 0x020004BE RID: 1214
		[ObfuscatedName("SplashScene.SceneManager+<OnDisplayingSplash>d__34")]
		public sealed class _OnDisplayingSplash_d__34 : ValueType
		{
			// Token: 0x06007FB1 RID: 32689 RVA: 0x002441F8 File Offset: 0x002423F8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnDisplayingSplash_d__34()
			{
				Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<OnDisplayingSplash>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr);
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>1__state");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>t__builder");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>4__this");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>8__1");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__selectedVisuals_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<selectedVisuals>5__2");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__loadingAssetHandle_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<loadingAssetHandle>5__3");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>u__1");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>7__wrap3");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>7__wrap4");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__assetHandle_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<assetHandle>5__6");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>u__2");
				SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, "<>7__wrap6");
				SceneManager._OnDisplayingSplash_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, 100664135);
				SceneManager._OnDisplayingSplash_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr, 100664136);
			}

			// Token: 0x06007FB2 RID: 32690 RVA: 0x0024433C File Offset: 0x0024253C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 25382, RefRangeEnd = 25385, XrefRangeStart = 25125, XrefRangeEnd = 25382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingSplash_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FB3 RID: 32691 RVA: 0x00244374 File Offset: 0x00242574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingSplash_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FB4 RID: 32692 RVA: 0x00044B6E File Offset: 0x00042D6E
			public _OnDisplayingSplash_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007FB5 RID: 32693 RVA: 0x00044B77 File Offset: 0x00042D77
			public _OnDisplayingSplash_d__34() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._OnDisplayingSplash_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17002B17 RID: 11031
			// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x002443BC File Offset: 0x002425BC
			// (set) Token: 0x06007FB7 RID: 32695 RVA: 0x00044B89 File Offset: 0x00042D89
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B18 RID: 11032
			// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x002443E4 File Offset: 0x002425E4
			// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x00044BA4 File Offset: 0x00042DA4
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B19 RID: 11033
			// (get) Token: 0x06007FBA RID: 32698 RVA: 0x00244414 File Offset: 0x00242614
			// (set) Token: 0x06007FBB RID: 32699 RVA: 0x00044BD2 File Offset: 0x00042DD2
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B1A RID: 11034
			// (get) Token: 0x06007FBC RID: 32700 RVA: 0x00244444 File Offset: 0x00242644
			// (set) Token: 0x06007FBD RID: 32701 RVA: 0x00044BF1 File Offset: 0x00042DF1
			public unsafe SceneManager.__c__DisplayClass34_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass34_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B1B RID: 11035
			// (get) Token: 0x06007FBE RID: 32702 RVA: 0x00244474 File Offset: 0x00242674
			// (set) Token: 0x06007FBF RID: 32703 RVA: 0x00044C10 File Offset: 0x00042E10
			public unsafe IEnumerable<SceneManager.SplashVisualPair> _selectedVisuals_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__selectedVisuals_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<SceneManager.SplashVisualPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__selectedVisuals_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B1C RID: 11036
			// (get) Token: 0x06007FC0 RID: 32704 RVA: 0x002444A4 File Offset: 0x002426A4
			// (set) Token: 0x06007FC1 RID: 32705 RVA: 0x00044C2F File Offset: 0x00042E2F
			public unsafe Dictionary<SceneManager.SplashVisualPair, ValueTuple<bool, UniTask<IAssetHandle<VideoClip>>>> _loadingAssetHandle_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__loadingAssetHandle_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SceneManager.SplashVisualPair, ValueTuple<bool, UniTask<IAssetHandle<VideoClip>>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__loadingAssetHandle_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B1D RID: 11037
			// (get) Token: 0x06007FC2 RID: 32706 RVA: 0x002444D4 File Offset: 0x002426D4
			// (set) Token: 0x06007FC3 RID: 32707 RVA: 0x00044C4E File Offset: 0x00042E4E
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B1E RID: 11038
			// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x00244504 File Offset: 0x00242704
			// (set) Token: 0x06007FC5 RID: 32709 RVA: 0x00044C7C File Offset: 0x00042E7C
			public unsafe Il2CppReferenceArray<SceneManager.SplashVisualPair> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SceneManager.SplashVisualPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B1F RID: 11039
			// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x00244534 File Offset: 0x00242734
			// (set) Token: 0x06007FC7 RID: 32711 RVA: 0x00044C9B File Offset: 0x00042E9B
			public unsafe int __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap4)) = value;
				}
			}

			// Token: 0x17002B20 RID: 11040
			// (get) Token: 0x06007FC8 RID: 32712 RVA: 0x0024455C File Offset: 0x0024275C
			// (set) Token: 0x06007FC9 RID: 32713 RVA: 0x00044CB6 File Offset: 0x00042EB6
			public SceneManager.SplashVisualPair _assetHandle_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__assetHandle_5__6);
					return new SceneManager.SplashVisualPair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr__assetHandle_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneManager.SplashVisualPair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B21 RID: 11041
			// (get) Token: 0x06007FCA RID: 32714 RVA: 0x0024458C File Offset: 0x0024278C
			// (set) Token: 0x06007FCB RID: 32715 RVA: 0x00044CE4 File Offset: 0x00042EE4
			public UniTask<IAssetHandle<VideoClip>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___u__2);
					return new UniTask<IAssetHandle<VideoClip>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<VideoClip>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<VideoClip>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B22 RID: 11042
			// (get) Token: 0x06007FCC RID: 32716 RVA: 0x002445BC File Offset: 0x002427BC
			// (set) Token: 0x06007FCD RID: 32717 RVA: 0x00044D12 File Offset: 0x00042F12
			public unsafe IEnumerator<SceneManager.SplashVisualPair> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<SceneManager.SplashVisualPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingSplash_d__34.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040053E2 RID: 21474
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040053E3 RID: 21475
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040053E4 RID: 21476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040053E5 RID: 21477
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040053E6 RID: 21478
			private static readonly IntPtr NativeFieldInfoPtr__selectedVisuals_5__2;

			// Token: 0x040053E7 RID: 21479
			private static readonly IntPtr NativeFieldInfoPtr__loadingAssetHandle_5__3;

			// Token: 0x040053E8 RID: 21480
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040053E9 RID: 21481
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040053EA RID: 21482
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040053EB RID: 21483
			private static readonly IntPtr NativeFieldInfoPtr__assetHandle_5__6;

			// Token: 0x040053EC RID: 21484
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040053ED RID: 21485
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x040053EE RID: 21486
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040053EF RID: 21487
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004BF RID: 1215
		[ObfuscatedName("SplashScene.SceneManager+<DisplayImageSession>d__36")]
		public sealed class _DisplayImageSession_d__36 : ValueType
		{
			// Token: 0x06007FCE RID: 32718 RVA: 0x002445EC File Offset: 0x002427EC
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayImageSession_d__36()
			{
				Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<DisplayImageSession>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr);
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "<>1__state");
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "<>t__builder");
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "<>4__this");
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "canvasGroup");
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "cancellationToken");
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_displayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "displayDuration");
				SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, "<>u__1");
				SceneManager._DisplayImageSession_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, 100664137);
				SceneManager._DisplayImageSession_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr, 100664138);
			}

			// Token: 0x06007FCF RID: 32719 RVA: 0x002446CC File Offset: 0x002428CC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 25429, RefRangeEnd = 25431, XrefRangeStart = 25385, XrefRangeEnd = 25429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayImageSession_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FD0 RID: 32720 RVA: 0x00244704 File Offset: 0x00242904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayImageSession_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FD1 RID: 32721 RVA: 0x00044D31 File Offset: 0x00042F31
			public _DisplayImageSession_d__36(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007FD2 RID: 32722 RVA: 0x00044D3A File Offset: 0x00042F3A
			public _DisplayImageSession_d__36() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._DisplayImageSession_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x17002B23 RID: 11043
			// (get) Token: 0x06007FD3 RID: 32723 RVA: 0x0024474C File Offset: 0x0024294C
			// (set) Token: 0x06007FD4 RID: 32724 RVA: 0x00044D4C File Offset: 0x00042F4C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B24 RID: 11044
			// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x00244774 File Offset: 0x00242974
			// (set) Token: 0x06007FD6 RID: 32726 RVA: 0x00044D67 File Offset: 0x00042F67
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B25 RID: 11045
			// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x002447A4 File Offset: 0x002429A4
			// (set) Token: 0x06007FD8 RID: 32728 RVA: 0x00044D95 File Offset: 0x00042F95
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B26 RID: 11046
			// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x002447D4 File Offset: 0x002429D4
			// (set) Token: 0x06007FDA RID: 32730 RVA: 0x00044DB4 File Offset: 0x00042FB4
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B27 RID: 11047
			// (get) Token: 0x06007FDB RID: 32731 RVA: 0x00244804 File Offset: 0x00242A04
			// (set) Token: 0x06007FDC RID: 32732 RVA: 0x00044DD3 File Offset: 0x00042FD3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B28 RID: 11048
			// (get) Token: 0x06007FDD RID: 32733 RVA: 0x00244834 File Offset: 0x00242A34
			// (set) Token: 0x06007FDE RID: 32734 RVA: 0x00044E01 File Offset: 0x00043001
			public unsafe float displayDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_displayDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr_displayDuration)) = value;
				}
			}

			// Token: 0x17002B29 RID: 11049
			// (get) Token: 0x06007FDF RID: 32735 RVA: 0x0024485C File Offset: 0x00242A5C
			// (set) Token: 0x06007FE0 RID: 32736 RVA: 0x00044E1C File Offset: 0x0004301C
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayImageSession_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040053F0 RID: 21488
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040053F1 RID: 21489
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040053F2 RID: 21490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040053F3 RID: 21491
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x040053F4 RID: 21492
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040053F5 RID: 21493
			private static readonly IntPtr NativeFieldInfoPtr_displayDuration;

			// Token: 0x040053F6 RID: 21494
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040053F7 RID: 21495
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040053F8 RID: 21496
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004C0 RID: 1216
		[ObfuscatedName("SplashScene.SceneManager+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x06007FE1 RID: 32737 RVA: 0x0024488C File Offset: 0x00242A8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_isVideoPlayFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, "isVideoPlayFinished");
				SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, "cancellationToken");
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664139);
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__DisplayVideoSession_b__0_Internal_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664140);
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__DisplayVideoSession_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664141);
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__DisplayVideoSession_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664142);
			}

			// Token: 0x06007FE2 RID: 32738 RVA: 0x00244944 File Offset: 0x00242B44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FE3 RID: 32739 RVA: 0x00244980 File Offset: 0x00242B80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DisplayVideoSession_b__0(VideoPlayer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__DisplayVideoSession_b__0_Internal_Void_VideoPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FE4 RID: 32740 RVA: 0x002449C4 File Offset: 0x00242BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25431, XrefRangeEnd = 25434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DisplayVideoSession_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__DisplayVideoSession_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FE5 RID: 32741 RVA: 0x002449F8 File Offset: 0x00242BF8
			[CallerCount(0)]
			public unsafe bool _DisplayVideoSession_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__DisplayVideoSession_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007FE6 RID: 32742 RVA: 0x00044E4A File Offset: 0x0004304A
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B2A RID: 11050
			// (get) Token: 0x06007FE7 RID: 32743 RVA: 0x00244A34 File Offset: 0x00242C34
			// (set) Token: 0x06007FE8 RID: 32744 RVA: 0x00044E53 File Offset: 0x00043053
			public unsafe bool isVideoPlayFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_isVideoPlayFinished);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_isVideoPlayFinished)) = value;
				}
			}

			// Token: 0x17002B2B RID: 11051
			// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00244A5C File Offset: 0x00242C5C
			// (set) Token: 0x06007FEA RID: 32746 RVA: 0x00044E6E File Offset: 0x0004306E
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B2C RID: 11052
			// (get) Token: 0x06007FEB RID: 32747 RVA: 0x00244A8C File Offset: 0x00242C8C
			// (set) Token: 0x06007FEC RID: 32748 RVA: 0x00044E8D File Offset: 0x0004308D
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040053F9 RID: 21497
			private static readonly IntPtr NativeFieldInfoPtr_isVideoPlayFinished;

			// Token: 0x040053FA RID: 21498
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040053FB RID: 21499
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040053FC RID: 21500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040053FD RID: 21501
			private static readonly IntPtr NativeMethodInfoPtr__DisplayVideoSession_b__0_Internal_Void_VideoPlayer_0;

			// Token: 0x040053FE RID: 21502
			private static readonly IntPtr NativeMethodInfoPtr__DisplayVideoSession_b__1_Internal_Void_0;

			// Token: 0x040053FF RID: 21503
			private static readonly IntPtr NativeMethodInfoPtr__DisplayVideoSession_b__2_Internal_Boolean_0;
		}

		// Token: 0x020004C1 RID: 1217
		[ObfuscatedName("SplashScene.SceneManager+<DisplayVideoSession>d__37")]
		public sealed class _DisplayVideoSession_d__37 : ValueType
		{
			// Token: 0x06007FED RID: 32749 RVA: 0x00244ABC File Offset: 0x00242CBC
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayVideoSession_d__37()
			{
				Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<DisplayVideoSession>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr);
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "<>1__state");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "<>t__builder");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "<>4__this");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "cancellationToken");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr_loadingAssetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "loadingAssetHandle");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "<>8__1");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "<>u__1");
				SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, "<>u__2");
				SceneManager._DisplayVideoSession_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, 100664143);
				SceneManager._DisplayVideoSession_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr, 100664144);
			}

			// Token: 0x06007FEE RID: 32750 RVA: 0x00244BB0 File Offset: 0x00242DB0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 25536, RefRangeEnd = 25538, XrefRangeStart = 25434, XrefRangeEnd = 25536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayVideoSession_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FEF RID: 32751 RVA: 0x00244BE8 File Offset: 0x00242DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayVideoSession_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FF0 RID: 32752 RVA: 0x00044EBB File Offset: 0x000430BB
			public _DisplayVideoSession_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007FF1 RID: 32753 RVA: 0x00044EC4 File Offset: 0x000430C4
			public _DisplayVideoSession_d__37() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._DisplayVideoSession_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x17002B2D RID: 11053
			// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x00244C30 File Offset: 0x00242E30
			// (set) Token: 0x06007FF3 RID: 32755 RVA: 0x00044ED6 File Offset: 0x000430D6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B2E RID: 11054
			// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x00244C58 File Offset: 0x00242E58
			// (set) Token: 0x06007FF5 RID: 32757 RVA: 0x00044EF1 File Offset: 0x000430F1
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B2F RID: 11055
			// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x00244C88 File Offset: 0x00242E88
			// (set) Token: 0x06007FF7 RID: 32759 RVA: 0x00044F1F File Offset: 0x0004311F
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B30 RID: 11056
			// (get) Token: 0x06007FF8 RID: 32760 RVA: 0x00244CB8 File Offset: 0x00242EB8
			// (set) Token: 0x06007FF9 RID: 32761 RVA: 0x00044F3E File Offset: 0x0004313E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B31 RID: 11057
			// (get) Token: 0x06007FFA RID: 32762 RVA: 0x00244CE8 File Offset: 0x00242EE8
			// (set) Token: 0x06007FFB RID: 32763 RVA: 0x00044F6C File Offset: 0x0004316C
			public UniTask<IAssetHandle<VideoClip>> loadingAssetHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr_loadingAssetHandle);
					return new UniTask<IAssetHandle<VideoClip>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<VideoClip>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr_loadingAssetHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<VideoClip>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B32 RID: 11058
			// (get) Token: 0x06007FFC RID: 32764 RVA: 0x00244D18 File Offset: 0x00242F18
			// (set) Token: 0x06007FFD RID: 32765 RVA: 0x00044F9A File Offset: 0x0004319A
			public unsafe SceneManager.__c__DisplayClass37_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass37_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B33 RID: 11059
			// (get) Token: 0x06007FFE RID: 32766 RVA: 0x00244D48 File Offset: 0x00242F48
			// (set) Token: 0x06007FFF RID: 32767 RVA: 0x00044FB9 File Offset: 0x000431B9
			public UniTask<IAssetHandle<VideoClip>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<VideoClip>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<VideoClip>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<VideoClip>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B34 RID: 11060
			// (get) Token: 0x06008000 RID: 32768 RVA: 0x00244D78 File Offset: 0x00242F78
			// (set) Token: 0x06008001 RID: 32769 RVA: 0x00044FE7 File Offset: 0x000431E7
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayVideoSession_d__37.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005400 RID: 21504
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005401 RID: 21505
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005402 RID: 21506
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005403 RID: 21507
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04005404 RID: 21508
			private static readonly IntPtr NativeFieldInfoPtr_loadingAssetHandle;

			// Token: 0x04005405 RID: 21509
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005406 RID: 21510
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005407 RID: 21511
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005408 RID: 21512
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005409 RID: 21513
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004C2 RID: 1218
		[ObfuscatedName("SplashScene.SceneManager+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x06008002 RID: 32770 RVA: 0x00244DA8 File Offset: 0x00242FA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, "pair");
				SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, "canContinue");
				SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, "cancellationToken");
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664145);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664146);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664147);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664148);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664149);
			}

			// Token: 0x06008003 RID: 32771 RVA: 0x00244E88 File Offset: 0x00243088
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008004 RID: 32772 RVA: 0x00244EC4 File Offset: 0x002430C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25538, XrefRangeEnd = 25540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DisplayIn_b__0(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008005 RID: 32773 RVA: 0x00244F04 File Offset: 0x00243104
			[CallerCount(0)]
			public unsafe void _DisplayIn_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008006 RID: 32774 RVA: 0x00244F38 File Offset: 0x00243138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25540, XrefRangeEnd = 25543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DisplayIn_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008007 RID: 32775 RVA: 0x00244F6C File Offset: 0x0024316C
			[CallerCount(0)]
			public unsafe bool _DisplayIn_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__DisplayIn_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008008 RID: 32776 RVA: 0x00045015 File Offset: 0x00043215
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B35 RID: 11061
			// (get) Token: 0x06008009 RID: 32777 RVA: 0x00244FA8 File Offset: 0x002431A8
			// (set) Token: 0x0600800A RID: 32778 RVA: 0x0004501E File Offset: 0x0004321E
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B36 RID: 11062
			// (get) Token: 0x0600800B RID: 32779 RVA: 0x00244FD8 File Offset: 0x002431D8
			// (set) Token: 0x0600800C RID: 32780 RVA: 0x0004503D File Offset: 0x0004323D
			public unsafe CanvasGroup pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_pair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_pair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B37 RID: 11063
			// (get) Token: 0x0600800D RID: 32781 RVA: 0x00245008 File Offset: 0x00243208
			// (set) Token: 0x0600800E RID: 32782 RVA: 0x0004505C File Offset: 0x0004325C
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17002B38 RID: 11064
			// (get) Token: 0x0600800F RID: 32783 RVA: 0x00245030 File Offset: 0x00243230
			// (set) Token: 0x06008010 RID: 32784 RVA: 0x00045077 File Offset: 0x00043277
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400540A RID: 21514
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400540B RID: 21515
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x0400540C RID: 21516
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x0400540D RID: 21517
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400540E RID: 21518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400540F RID: 21519
			private static readonly IntPtr NativeMethodInfoPtr__DisplayIn_b__0_Internal_Void_Single_0;

			// Token: 0x04005410 RID: 21520
			private static readonly IntPtr NativeMethodInfoPtr__DisplayIn_b__1_Internal_Void_0;

			// Token: 0x04005411 RID: 21521
			private static readonly IntPtr NativeMethodInfoPtr__DisplayIn_b__2_Internal_Void_0;

			// Token: 0x04005412 RID: 21522
			private static readonly IntPtr NativeMethodInfoPtr__DisplayIn_b__3_Internal_Boolean_0;
		}

		// Token: 0x020004C3 RID: 1219
		[ObfuscatedName("SplashScene.SceneManager+<DisplayIn>d__39")]
		public sealed class _DisplayIn_d__39 : ValueType
		{
			// Token: 0x06008011 RID: 32785 RVA: 0x00245060 File Offset: 0x00243260
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayIn_d__39()
			{
				Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<DisplayIn>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr);
				SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, "<>1__state");
				SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, "<>t__builder");
				SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, "<>4__this");
				SceneManager._DisplayIn_d__39.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, "pair");
				SceneManager._DisplayIn_d__39.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, "cancellationToken");
				SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, "<>u__1");
				SceneManager._DisplayIn_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, 100664150);
				SceneManager._DisplayIn_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr, 100664151);
			}

			// Token: 0x06008012 RID: 32786 RVA: 0x0024512C File Offset: 0x0024332C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 25558, RefRangeEnd = 25560, XrefRangeStart = 25543, XrefRangeEnd = 25558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayIn_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008013 RID: 32787 RVA: 0x00245164 File Offset: 0x00243364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayIn_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008014 RID: 32788 RVA: 0x000450A5 File Offset: 0x000432A5
			public _DisplayIn_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008015 RID: 32789 RVA: 0x000450AE File Offset: 0x000432AE
			public _DisplayIn_d__39() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._DisplayIn_d__39>.NativeClassPtr))
			{
			}

			// Token: 0x17002B39 RID: 11065
			// (get) Token: 0x06008016 RID: 32790 RVA: 0x002451AC File Offset: 0x002433AC
			// (set) Token: 0x06008017 RID: 32791 RVA: 0x000450C0 File Offset: 0x000432C0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B3A RID: 11066
			// (get) Token: 0x06008018 RID: 32792 RVA: 0x002451D4 File Offset: 0x002433D4
			// (set) Token: 0x06008019 RID: 32793 RVA: 0x000450DB File Offset: 0x000432DB
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B3B RID: 11067
			// (get) Token: 0x0600801A RID: 32794 RVA: 0x00245204 File Offset: 0x00243404
			// (set) Token: 0x0600801B RID: 32795 RVA: 0x00045109 File Offset: 0x00043309
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B3C RID: 11068
			// (get) Token: 0x0600801C RID: 32796 RVA: 0x00245234 File Offset: 0x00243434
			// (set) Token: 0x0600801D RID: 32797 RVA: 0x00045128 File Offset: 0x00043328
			public unsafe CanvasGroup pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr_pair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr_pair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B3D RID: 11069
			// (get) Token: 0x0600801E RID: 32798 RVA: 0x00245264 File Offset: 0x00243464
			// (set) Token: 0x0600801F RID: 32799 RVA: 0x00045147 File Offset: 0x00043347
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B3E RID: 11070
			// (get) Token: 0x06008020 RID: 32800 RVA: 0x00245294 File Offset: 0x00243494
			// (set) Token: 0x06008021 RID: 32801 RVA: 0x00045175 File Offset: 0x00043375
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayIn_d__39.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005413 RID: 21523
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005414 RID: 21524
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005415 RID: 21525
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005416 RID: 21526
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x04005417 RID: 21527
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04005418 RID: 21528
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005419 RID: 21529
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400541A RID: 21530
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004C4 RID: 1220
		[ObfuscatedName("SplashScene.SceneManager+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x06008022 RID: 32802 RVA: 0x002452C4 File Offset: 0x002434C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, "pair");
				SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, "canContinue");
				SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, "cancellationToken");
				SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, 100664152);
				SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, 100664153);
				SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, 100664154);
				SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, 100664155);
				SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr, 100664156);
			}

			// Token: 0x06008023 RID: 32803 RVA: 0x002453A4 File Offset: 0x002435A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008024 RID: 32804 RVA: 0x002453E0 File Offset: 0x002435E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DisplayOut_b__0(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008025 RID: 32805 RVA: 0x00245420 File Offset: 0x00243620
			[CallerCount(0)]
			public unsafe void _DisplayOut_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008026 RID: 32806 RVA: 0x00245454 File Offset: 0x00243654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DisplayOut_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008027 RID: 32807 RVA: 0x00245488 File Offset: 0x00243688
			[CallerCount(0)]
			public unsafe bool _DisplayOut_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass41_0.NativeMethodInfoPtr__DisplayOut_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008028 RID: 32808 RVA: 0x000451A3 File Offset: 0x000433A3
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B3F RID: 11071
			// (get) Token: 0x06008029 RID: 32809 RVA: 0x002454C4 File Offset: 0x002436C4
			// (set) Token: 0x0600802A RID: 32810 RVA: 0x000451AC File Offset: 0x000433AC
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B40 RID: 11072
			// (get) Token: 0x0600802B RID: 32811 RVA: 0x002454F4 File Offset: 0x002436F4
			// (set) Token: 0x0600802C RID: 32812 RVA: 0x000451CB File Offset: 0x000433CB
			public unsafe CanvasGroup pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_pair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_pair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B41 RID: 11073
			// (get) Token: 0x0600802D RID: 32813 RVA: 0x00245524 File Offset: 0x00243724
			// (set) Token: 0x0600802E RID: 32814 RVA: 0x000451EA File Offset: 0x000433EA
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17002B42 RID: 11074
			// (get) Token: 0x0600802F RID: 32815 RVA: 0x0024554C File Offset: 0x0024374C
			// (set) Token: 0x06008030 RID: 32816 RVA: 0x00045205 File Offset: 0x00043405
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass41_0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400541B RID: 21531
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400541C RID: 21532
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x0400541D RID: 21533
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x0400541E RID: 21534
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400541F RID: 21535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005420 RID: 21536
			private static readonly IntPtr NativeMethodInfoPtr__DisplayOut_b__0_Internal_Void_Single_0;

			// Token: 0x04005421 RID: 21537
			private static readonly IntPtr NativeMethodInfoPtr__DisplayOut_b__1_Internal_Void_0;

			// Token: 0x04005422 RID: 21538
			private static readonly IntPtr NativeMethodInfoPtr__DisplayOut_b__2_Internal_Void_0;

			// Token: 0x04005423 RID: 21539
			private static readonly IntPtr NativeMethodInfoPtr__DisplayOut_b__3_Internal_Boolean_0;
		}

		// Token: 0x020004C5 RID: 1221
		[ObfuscatedName("SplashScene.SceneManager+<DisplayOut>d__41")]
		public sealed class _DisplayOut_d__41 : ValueType
		{
			// Token: 0x06008031 RID: 32817 RVA: 0x0024557C File Offset: 0x0024377C
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayOut_d__41()
			{
				Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<DisplayOut>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr);
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "<>1__state");
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "<>t__builder");
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "<>4__this");
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "pair");
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "cancellationToken");
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "<>8__1");
				SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, "<>u__1");
				SceneManager._DisplayOut_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, 100664157);
				SceneManager._DisplayOut_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr, 100664158);
			}

			// Token: 0x06008032 RID: 32818 RVA: 0x0024565C File Offset: 0x0024385C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 25579, RefRangeEnd = 25581, XrefRangeStart = 25560, XrefRangeEnd = 25579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayOut_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008033 RID: 32819 RVA: 0x00245694 File Offset: 0x00243894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._DisplayOut_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008034 RID: 32820 RVA: 0x00045233 File Offset: 0x00043433
			public _DisplayOut_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008035 RID: 32821 RVA: 0x0004523C File Offset: 0x0004343C
			public _DisplayOut_d__41() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._DisplayOut_d__41>.NativeClassPtr))
			{
			}

			// Token: 0x17002B43 RID: 11075
			// (get) Token: 0x06008036 RID: 32822 RVA: 0x002456DC File Offset: 0x002438DC
			// (set) Token: 0x06008037 RID: 32823 RVA: 0x0004524E File Offset: 0x0004344E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B44 RID: 11076
			// (get) Token: 0x06008038 RID: 32824 RVA: 0x00245704 File Offset: 0x00243904
			// (set) Token: 0x06008039 RID: 32825 RVA: 0x00045269 File Offset: 0x00043469
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B45 RID: 11077
			// (get) Token: 0x0600803A RID: 32826 RVA: 0x00245734 File Offset: 0x00243934
			// (set) Token: 0x0600803B RID: 32827 RVA: 0x00045297 File Offset: 0x00043497
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B46 RID: 11078
			// (get) Token: 0x0600803C RID: 32828 RVA: 0x00245764 File Offset: 0x00243964
			// (set) Token: 0x0600803D RID: 32829 RVA: 0x000452B6 File Offset: 0x000434B6
			public unsafe CanvasGroup pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr_pair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr_pair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B47 RID: 11079
			// (get) Token: 0x0600803E RID: 32830 RVA: 0x00245794 File Offset: 0x00243994
			// (set) Token: 0x0600803F RID: 32831 RVA: 0x000452D5 File Offset: 0x000434D5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B48 RID: 11080
			// (get) Token: 0x06008040 RID: 32832 RVA: 0x002457C4 File Offset: 0x002439C4
			// (set) Token: 0x06008041 RID: 32833 RVA: 0x00045303 File Offset: 0x00043503
			public unsafe SceneManager.__c__DisplayClass41_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B49 RID: 11081
			// (get) Token: 0x06008042 RID: 32834 RVA: 0x002457F4 File Offset: 0x002439F4
			// (set) Token: 0x06008043 RID: 32835 RVA: 0x00045322 File Offset: 0x00043522
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._DisplayOut_d__41.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005424 RID: 21540
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005425 RID: 21541
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005426 RID: 21542
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005427 RID: 21543
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x04005428 RID: 21544
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04005429 RID: 21545
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400542A RID: 21546
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400542B RID: 21547
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400542C RID: 21548
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
