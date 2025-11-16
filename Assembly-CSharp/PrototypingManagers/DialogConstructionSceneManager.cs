using System;
using Cinemachine;
using DEYU.SceneComposer;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace PrototypingManagers
{
	// Token: 0x02000048 RID: 72
	public class DialogConstructionSceneManager : MonoBehaviour
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x000B9E58 File Offset: 0x000B8058
		// Note: this type is marked as 'beforefieldinit'.
		static DialogConstructionSceneManager()
		{
			Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "DialogConstructionSceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr);
			DialogConstructionSceneManager.NativeFieldInfoPtr_transitionModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, "transitionModule");
			DialogConstructionSceneManager.NativeFieldInfoPtr_packageToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, "packageToRun");
			DialogConstructionSceneManager.NativeFieldInfoPtr_virtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, "virtualCamera");
			DialogConstructionSceneManager.NativeFieldInfoPtr_m_IsDialogPannelOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, "m_IsDialogPannelOn");
			DialogConstructionSceneManager.NativeMethodInfoPtr_get_Director_Private_get_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, 100664735);
			DialogConstructionSceneManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, 100664736);
			DialogConstructionSceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr, 100664737);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000B9F14 File Offset: 0x000B8114
		public unsafe PlayableDirector Director
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36349, XrefRangeEnd = 36352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogConstructionSceneManager.NativeMethodInfoPtr_get_Director_Private_get_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr3) : null;
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000B9F54 File Offset: 0x000B8154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36352, XrefRangeEnd = 36388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogConstructionSceneManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000B9F88 File Offset: 0x000B8188
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogConstructionSceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogConstructionSceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogConstructionSceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00007191 File Offset: 0x00005391
		public DialogConstructionSceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000B9FC4 File Offset: 0x000B81C4
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0000719A File Offset: 0x0000539A
		public unsafe TransitingModuleBase transitionModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_transitionModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitingModuleBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_transitionModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000B9FF4 File Offset: 0x000B81F4
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000071B9 File Offset: 0x000053B9
		public unsafe DialogPackage packageToRun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_packageToRun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_packageToRun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x000BA024 File Offset: 0x000B8224
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x000071D8 File Offset: 0x000053D8
		public unsafe CinemachineVirtualCamera virtualCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_virtualCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineVirtualCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_virtualCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000BA054 File Offset: 0x000B8254
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x000071F7 File Offset: 0x000053F7
		public unsafe bool m_IsDialogPannelOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_m_IsDialogPannelOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogConstructionSceneManager.NativeFieldInfoPtr_m_IsDialogPannelOn)) = value;
			}
		}

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_transitionModule;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_packageToRun;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_virtualCamera;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDialogPannelOn;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get_Director_Private_get_PlayableDirector_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
