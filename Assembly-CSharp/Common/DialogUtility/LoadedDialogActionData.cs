using System;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Common.DialogUtility
{
	// Token: 0x02000346 RID: 838
	public class LoadedDialogActionData : Il2CppSystem.Object
	{
		// Token: 0x0600638F RID: 25487 RVA: 0x001EB384 File Offset: 0x001E9584
		// Note: this type is marked as 'beforefieldinit'.
		static LoadedDialogActionData()
		{
			Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "LoadedDialogActionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr);
			LoadedDialogActionData.NativeFieldInfoPtr_m_DialogActionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, "m_DialogActionData");
			LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, "m_LoadedAudio");
			LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedBgmPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, "m_LoadedBgmPackage");
			LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, "m_LoadedMaterial");
			LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, "m_LoadedSprite");
			LoadedDialogActionData.NativeMethodInfoPtr__ctor_Private_Void_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_IAssetHandle_1_AudioClip_IAssetHandle_1_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684223);
			LoadedDialogActionData.NativeMethodInfoPtr__ctor_Private_Void_DialogAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684224);
			LoadedDialogActionData.NativeMethodInfoPtr_get_DialogActionType_Public_get_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684225);
			LoadedDialogActionData.NativeMethodInfoPtr_get_DialogSelections_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684226);
			LoadedDialogActionData.NativeMethodInfoPtr_get_DialogJumps_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684227);
			LoadedDialogActionData.NativeMethodInfoPtr_get_DialogPrices_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684228);
			LoadedDialogActionData.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684229);
			LoadedDialogActionData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684230);
			LoadedDialogActionData.NativeMethodInfoPtr_Run_Public_Void_DialogPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684231);
			LoadedDialogActionData.NativeMethodInfoPtr_CreateDefault_Public_Static_LoadedDialogActionData_DialogAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684232);
			LoadedDialogActionData.NativeMethodInfoPtr_CreateBg_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684233);
			LoadedDialogActionData.NativeMethodInfoPtr_CreateCg_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684234);
			LoadedDialogActionData.NativeMethodInfoPtr_CreateBgm_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684235);
			LoadedDialogActionData.NativeMethodInfoPtr_CreateSound_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr, 100684236);
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x001EB530 File Offset: 0x001E9730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257135, XrefRangeEnd = 257141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadedDialogActionData(DialogAction dialogActionData, IAssetHandle<Sprite> loadedSprite = null, IAssetHandle<Material> loadedMaterial = null, IAssetHandle<AudioClip> loadedAudio = null, IAssetHandle<LoopedBGMPackage> loadedBgmPackage = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogActionData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedSprite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedMaterial);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedAudio);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedBgmPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr__ctor_Private_Void_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_IAssetHandle_1_AudioClip_IAssetHandle_1_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x001EB5C8 File Offset: 0x001E97C8
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadedDialogActionData(DialogAction dialogActionData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedDialogActionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogActionData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr__ctor_Private_Void_DialogAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x001EB614 File Offset: 0x001E9814
		public unsafe ActionType DialogActionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_get_DialogActionType_Public_get_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06006393 RID: 25491 RVA: 0x001EB650 File Offset: 0x001E9850
		public unsafe Il2CppStructArray<int> DialogSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_get_DialogSelections_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x001EB690 File Offset: 0x001E9890
		public unsafe Il2CppStructArray<int> DialogJumps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_get_DialogJumps_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06006395 RID: 25493 RVA: 0x001EB6D0 File Offset: 0x001E98D0
		public unsafe Il2CppStructArray<int> DialogPrices
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 257141, RefRangeEnd = 257144, XrefRangeStart = 257141, XrefRangeEnd = 257141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_get_DialogPrices_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06006396 RID: 25494 RVA: 0x001EB710 File Offset: 0x001E9910
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x001EB74C File Offset: 0x001E994C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257144, XrefRangeEnd = 257153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x001EB780 File Offset: 0x001E9980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257169, RefRangeEnd = 257170, XrefRangeStart = 257153, XrefRangeEnd = 257169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run(DialogPannel dialogModuleUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogModuleUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_Run_Public_Void_DialogPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x001EB7C4 File Offset: 0x001E99C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257170, XrefRangeEnd = 257175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LoadedDialogActionData CreateDefault(DialogAction dialogAction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_CreateDefault_Public_Static_LoadedDialogActionData_DialogAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadedDialogActionData>(intPtr3) : null;
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x001EB808 File Offset: 0x001E9A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257175, XrefRangeEnd = 257184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LoadedDialogActionData CreateBg(DialogAction dialogAction, IAssetHandle<Sprite> bgAssetHandle, IAssetHandle<Material> materialAssetHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogAction);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgAssetHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(materialAssetHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_CreateBg_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadedDialogActionData>(intPtr3) : null;
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x001EB870 File Offset: 0x001E9A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257184, XrefRangeEnd = 257193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LoadedDialogActionData CreateCg(DialogAction dialogAction, IAssetHandle<Sprite> cgAssetHandle, IAssetHandle<Material> materialAssetHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogAction);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cgAssetHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(materialAssetHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_CreateCg_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadedDialogActionData>(intPtr3) : null;
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x001EB8D8 File Offset: 0x001E9AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257193, XrefRangeEnd = 257202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LoadedDialogActionData CreateBgm(DialogAction dialogAction, IAssetHandle<LoopedBGMPackage> bgmAssetHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogAction);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgmAssetHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_CreateBgm_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_LoopedBGMPackage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadedDialogActionData>(intPtr3) : null;
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x001EB930 File Offset: 0x001E9B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257202, XrefRangeEnd = 257211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LoadedDialogActionData CreateSound(DialogAction dialogAction, IAssetHandle<AudioClip> soundAssetHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogAction);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(soundAssetHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedDialogActionData.NativeMethodInfoPtr_CreateSound_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_AudioClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadedDialogActionData>(intPtr3) : null;
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x00035CF9 File Offset: 0x00033EF9
		public LoadedDialogActionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600639F RID: 25503 RVA: 0x001EB988 File Offset: 0x001E9B88
		// (set) Token: 0x060063A0 RID: 25504 RVA: 0x00035D02 File Offset: 0x00033F02
		public unsafe DialogAction m_DialogActionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_DialogActionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_DialogActionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x060063A1 RID: 25505 RVA: 0x001EB9B8 File Offset: 0x001E9BB8
		// (set) Token: 0x060063A2 RID: 25506 RVA: 0x00035D21 File Offset: 0x00033F21
		public unsafe IAssetHandle<AudioClip> m_LoadedAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x060063A3 RID: 25507 RVA: 0x001EB9E8 File Offset: 0x001E9BE8
		// (set) Token: 0x060063A4 RID: 25508 RVA: 0x00035D40 File Offset: 0x00033F40
		public unsafe IAssetHandle<LoopedBGMPackage> m_LoadedBgmPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedBgmPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<LoopedBGMPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedBgmPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x060063A5 RID: 25509 RVA: 0x001EBA18 File Offset: 0x001E9C18
		// (set) Token: 0x060063A6 RID: 25510 RVA: 0x00035D5F File Offset: 0x00033F5F
		public unsafe IAssetHandle<Material> m_LoadedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x060063A7 RID: 25511 RVA: 0x001EBA48 File Offset: 0x001E9C48
		// (set) Token: 0x060063A8 RID: 25512 RVA: 0x00035D7E File Offset: 0x00033F7E
		public unsafe IAssetHandle<Sprite> m_LoadedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedDialogActionData.NativeFieldInfoPtr_m_LoadedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004210 RID: 16912
		private static readonly IntPtr NativeFieldInfoPtr_m_DialogActionData;

		// Token: 0x04004211 RID: 16913
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedAudio;

		// Token: 0x04004212 RID: 16914
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedBgmPackage;

		// Token: 0x04004213 RID: 16915
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedMaterial;

		// Token: 0x04004214 RID: 16916
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedSprite;

		// Token: 0x04004215 RID: 16917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_IAssetHandle_1_AudioClip_IAssetHandle_1_LoopedBGMPackage_0;

		// Token: 0x04004216 RID: 16918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DialogAction_0;

		// Token: 0x04004217 RID: 16919
		private static readonly IntPtr NativeMethodInfoPtr_get_DialogActionType_Public_get_ActionType_0;

		// Token: 0x04004218 RID: 16920
		private static readonly IntPtr NativeMethodInfoPtr_get_DialogSelections_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04004219 RID: 16921
		private static readonly IntPtr NativeMethodInfoPtr_get_DialogJumps_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400421A RID: 16922
		private static readonly IntPtr NativeMethodInfoPtr_get_DialogPrices_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400421B RID: 16923
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x0400421C RID: 16924
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400421D RID: 16925
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_DialogPannel_0;

		// Token: 0x0400421E RID: 16926
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_LoadedDialogActionData_DialogAction_0;

		// Token: 0x0400421F RID: 16927
		private static readonly IntPtr NativeMethodInfoPtr_CreateBg_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_0;

		// Token: 0x04004220 RID: 16928
		private static readonly IntPtr NativeMethodInfoPtr_CreateCg_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_Sprite_IAssetHandle_1_Material_0;

		// Token: 0x04004221 RID: 16929
		private static readonly IntPtr NativeMethodInfoPtr_CreateBgm_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_LoopedBGMPackage_0;

		// Token: 0x04004222 RID: 16930
		private static readonly IntPtr NativeMethodInfoPtr_CreateSound_Public_Static_LoadedDialogActionData_DialogAction_IAssetHandle_1_AudioClip_0;
	}
}
