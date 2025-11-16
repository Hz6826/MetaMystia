using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Common.DialogUtility
{
	// Token: 0x02000347 RID: 839
	[Serializable]
	public class DialogAction : Il2CppSystem.Object
	{
		// Token: 0x060063A9 RID: 25513 RVA: 0x001EBA78 File Offset: 0x001E9C78
		// Note: this type is marked as 'beforefieldinit'.
		static DialogAction()
		{
			Il2CppClassPointerStore<DialogAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "DialogAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogAction>.NativeClassPtr);
			DialogAction.NativeFieldInfoPtr_shouldSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "shouldSet");
			DialogAction.NativeFieldInfoPtr_foregroundCleaning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "foregroundCleaning");
			DialogAction.NativeFieldInfoPtr_actionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "actionType");
			DialogAction.NativeFieldInfoPtr_selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "selections");
			DialogAction.NativeFieldInfoPtr_jumps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "jumps");
			DialogAction.NativeFieldInfoPtr_prices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "prices");
			DialogAction.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "index");
			DialogAction.NativeFieldInfoPtr_m_SpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_SpriteAsset");
			DialogAction.NativeFieldInfoPtr_m_SpriteENAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_SpriteENAsset");
			DialogAction.NativeFieldInfoPtr_m_SpriteJPAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_SpriteJPAsset");
			DialogAction.NativeFieldInfoPtr_m_SpriteKOAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_SpriteKOAsset");
			DialogAction.NativeFieldInfoPtr_m_SpriteCNTAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_SpriteCNTAsset");
			DialogAction.NativeFieldInfoPtr_m_MaterialAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_MaterialAsset");
			DialogAction.NativeFieldInfoPtr_m_AudioAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_AudioAsset");
			DialogAction.NativeFieldInfoPtr_m_BgmPackageAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "m_BgmPackageAsset");
			DialogAction.NativeMethodInfoPtr_LoadAssetAllowNull_Private_UniTask_1_IAssetHandle_1_T_AssetReferenceT_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, 100684237);
			DialogAction.NativeMethodInfoPtr_LoadDialogActionData_Public_UniTask_1_LoadedDialogActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, 100684238);
			DialogAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, 100684239);
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x001EBC10 File Offset: 0x001E9E10
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 257401, RefRangeEnd = 257407, XrefRangeStart = 257396, XrefRangeEnd = 257401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandle<T>> LoadAssetAllowNull<T>(AssetReferenceT<T> assetReferenceT) where T : UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetReferenceT);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogAction.MethodInfoStoreGeneric_LoadAssetAllowNull_Private_UniTask_1_IAssetHandle_1_T_AssetReferenceT_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<T>>(pointer);
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x001EBC58 File Offset: 0x001E9E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257407, XrefRangeEnd = 257416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<LoadedDialogActionData> LoadDialogActionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogAction.NativeMethodInfoPtr_LoadDialogActionData_Public_UniTask_1_LoadedDialogActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<LoadedDialogActionData>(pointer);
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x001EBC90 File Offset: 0x001E9E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257416, XrefRangeEnd = 257417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00035D9D File Offset: 0x00033F9D
		public DialogAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x001EBCCC File Offset: 0x001E9ECC
		// (set) Token: 0x060063AF RID: 25519 RVA: 0x00035DA6 File Offset: 0x00033FA6
		public unsafe bool shouldSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_shouldSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_shouldSet)) = value;
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x060063B0 RID: 25520 RVA: 0x001EBCF4 File Offset: 0x001E9EF4
		// (set) Token: 0x060063B1 RID: 25521 RVA: 0x00035DC1 File Offset: 0x00033FC1
		public unsafe Il2CppStructArray<Position> foregroundCleaning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_foregroundCleaning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Position>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_foregroundCleaning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x060063B2 RID: 25522 RVA: 0x001EBD24 File Offset: 0x001E9F24
		// (set) Token: 0x060063B3 RID: 25523 RVA: 0x00035DE0 File Offset: 0x00033FE0
		public unsafe ActionType actionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_actionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_actionType)) = value;
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x060063B4 RID: 25524 RVA: 0x001EBD4C File Offset: 0x001E9F4C
		// (set) Token: 0x060063B5 RID: 25525 RVA: 0x00035DFB File Offset: 0x00033FFB
		public unsafe Il2CppStructArray<int> selections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_selections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_selections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x060063B6 RID: 25526 RVA: 0x001EBD7C File Offset: 0x001E9F7C
		// (set) Token: 0x060063B7 RID: 25527 RVA: 0x00035E1A File Offset: 0x0003401A
		public unsafe Il2CppStructArray<int> jumps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_jumps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_jumps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x060063B8 RID: 25528 RVA: 0x001EBDAC File Offset: 0x001E9FAC
		// (set) Token: 0x060063B9 RID: 25529 RVA: 0x00035E39 File Offset: 0x00034039
		public unsafe Il2CppStructArray<int> prices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_prices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_prices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x060063BA RID: 25530 RVA: 0x001EBDDC File Offset: 0x001E9FDC
		// (set) Token: 0x060063BB RID: 25531 RVA: 0x00035E58 File Offset: 0x00034058
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x060063BC RID: 25532 RVA: 0x001EBE04 File Offset: 0x001EA004
		// (set) Token: 0x060063BD RID: 25533 RVA: 0x00035E73 File Offset: 0x00034073
		public unsafe AssetReferenceSprite m_SpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x001EBE34 File Offset: 0x001EA034
		// (set) Token: 0x060063BF RID: 25535 RVA: 0x00035E92 File Offset: 0x00034092
		public unsafe AssetReferenceSprite m_SpriteENAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteENAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteENAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x001EBE64 File Offset: 0x001EA064
		// (set) Token: 0x060063C1 RID: 25537 RVA: 0x00035EB1 File Offset: 0x000340B1
		public unsafe AssetReferenceSprite m_SpriteJPAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteJPAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteJPAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x001EBE94 File Offset: 0x001EA094
		// (set) Token: 0x060063C3 RID: 25539 RVA: 0x00035ED0 File Offset: 0x000340D0
		public unsafe AssetReferenceSprite m_SpriteKOAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteKOAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteKOAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x001EBEC4 File Offset: 0x001EA0C4
		// (set) Token: 0x060063C5 RID: 25541 RVA: 0x00035EEF File Offset: 0x000340EF
		public unsafe AssetReferenceSprite m_SpriteCNTAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteCNTAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_SpriteCNTAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x001EBEF4 File Offset: 0x001EA0F4
		// (set) Token: 0x060063C7 RID: 25543 RVA: 0x00035F0E File Offset: 0x0003410E
		public unsafe AssetReferenceT<Material> m_MaterialAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_MaterialAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_MaterialAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x060063C8 RID: 25544 RVA: 0x001EBF24 File Offset: 0x001EA124
		// (set) Token: 0x060063C9 RID: 25545 RVA: 0x00035F2D File Offset: 0x0003412D
		public unsafe AssetReferenceT<AudioClip> m_AudioAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_AudioAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_AudioAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x001EBF54 File Offset: 0x001EA154
		// (set) Token: 0x060063CB RID: 25547 RVA: 0x00035F4C File Offset: 0x0003414C
		public unsafe AssetReferenceT<LoopedBGMPackage> m_BgmPackageAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_BgmPackageAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<LoopedBGMPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction.NativeFieldInfoPtr_m_BgmPackageAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004223 RID: 16931
		private static readonly IntPtr NativeFieldInfoPtr_shouldSet;

		// Token: 0x04004224 RID: 16932
		private static readonly IntPtr NativeFieldInfoPtr_foregroundCleaning;

		// Token: 0x04004225 RID: 16933
		private static readonly IntPtr NativeFieldInfoPtr_actionType;

		// Token: 0x04004226 RID: 16934
		private static readonly IntPtr NativeFieldInfoPtr_selections;

		// Token: 0x04004227 RID: 16935
		private static readonly IntPtr NativeFieldInfoPtr_jumps;

		// Token: 0x04004228 RID: 16936
		private static readonly IntPtr NativeFieldInfoPtr_prices;

		// Token: 0x04004229 RID: 16937
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400422A RID: 16938
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteAsset;

		// Token: 0x0400422B RID: 16939
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteENAsset;

		// Token: 0x0400422C RID: 16940
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteJPAsset;

		// Token: 0x0400422D RID: 16941
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteKOAsset;

		// Token: 0x0400422E RID: 16942
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCNTAsset;

		// Token: 0x0400422F RID: 16943
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialAsset;

		// Token: 0x04004230 RID: 16944
		private static readonly IntPtr NativeFieldInfoPtr_m_AudioAsset;

		// Token: 0x04004231 RID: 16945
		private static readonly IntPtr NativeFieldInfoPtr_m_BgmPackageAsset;

		// Token: 0x04004232 RID: 16946
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAllowNull_Private_UniTask_1_IAssetHandle_1_T_AssetReferenceT_1_T_0;

		// Token: 0x04004233 RID: 16947
		private static readonly IntPtr NativeMethodInfoPtr_LoadDialogActionData_Public_UniTask_1_LoadedDialogActionData_0;

		// Token: 0x04004234 RID: 16948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E00 RID: 3584
		[ObfuscatedName("Common.DialogUtility.DialogAction+<LoadDialogActionData>d__16")]
		public sealed class _LoadDialogActionData_d__16 : ValueType
		{
			// Token: 0x060102A2 RID: 66210 RVA: 0x003C4F48 File Offset: 0x003C3148
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadDialogActionData_d__16()
			{
				Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogAction>.NativeClassPtr, "<LoadDialogActionData>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr);
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>1__state");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>t__builder");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>4__this");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>7__wrap1");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>u__1");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>u__2");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>u__3");
				DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, "<>u__4");
				DialogAction._LoadDialogActionData_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, 100684240);
				DialogAction._LoadDialogActionData_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr, 100684241);
			}

			// Token: 0x060102A3 RID: 66211 RVA: 0x003C503C File Offset: 0x003C323C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 257390, RefRangeEnd = 257393, XrefRangeStart = 257211, XrefRangeEnd = 257390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogAction._LoadDialogActionData_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102A4 RID: 66212 RVA: 0x003C5074 File Offset: 0x003C3274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257393, XrefRangeEnd = 257396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogAction._LoadDialogActionData_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102A5 RID: 66213 RVA: 0x0008CA73 File Offset: 0x0008AC73
			public _LoadDialogActionData_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060102A6 RID: 66214 RVA: 0x0008CA7C File Offset: 0x0008AC7C
			public _LoadDialogActionData_d__16() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogAction._LoadDialogActionData_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17005484 RID: 21636
			// (get) Token: 0x060102A7 RID: 66215 RVA: 0x003C50BC File Offset: 0x003C32BC
			// (set) Token: 0x060102A8 RID: 66216 RVA: 0x0008CA8E File Offset: 0x0008AC8E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005485 RID: 21637
			// (get) Token: 0x060102A9 RID: 66217 RVA: 0x003C50E4 File Offset: 0x003C32E4
			// (set) Token: 0x060102AA RID: 66218 RVA: 0x0008CAA9 File Offset: 0x0008ACA9
			public AsyncUniTaskMethodBuilder<LoadedDialogActionData> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<LoadedDialogActionData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<LoadedDialogActionData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<LoadedDialogActionData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005486 RID: 21638
			// (get) Token: 0x060102AB RID: 66219 RVA: 0x003C5114 File Offset: 0x003C3314
			// (set) Token: 0x060102AC RID: 66220 RVA: 0x0008CAD7 File Offset: 0x0008ACD7
			public unsafe DialogAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005487 RID: 21639
			// (get) Token: 0x060102AD RID: 66221 RVA: 0x003C5144 File Offset: 0x003C3344
			// (set) Token: 0x060102AE RID: 66222 RVA: 0x0008CAF6 File Offset: 0x0008ACF6
			public unsafe IAssetHandle<Sprite> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005488 RID: 21640
			// (get) Token: 0x060102AF RID: 66223 RVA: 0x003C5174 File Offset: 0x003C3374
			// (set) Token: 0x060102B0 RID: 66224 RVA: 0x0008CB15 File Offset: 0x0008AD15
			public UniTask<IAssetHandle<Sprite>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<Sprite>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005489 RID: 21641
			// (get) Token: 0x060102B1 RID: 66225 RVA: 0x003C51A4 File Offset: 0x003C33A4
			// (set) Token: 0x060102B2 RID: 66226 RVA: 0x0008CB43 File Offset: 0x0008AD43
			public UniTask<IAssetHandle<Material>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__2);
					return new UniTask<IAssetHandle<Material>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<Material>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<Material>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700548A RID: 21642
			// (get) Token: 0x060102B3 RID: 66227 RVA: 0x003C51D4 File Offset: 0x003C33D4
			// (set) Token: 0x060102B4 RID: 66228 RVA: 0x0008CB71 File Offset: 0x0008AD71
			public UniTask<IAssetHandle<AudioClip>>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__3);
					return new UniTask<IAssetHandle<AudioClip>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<AudioClip>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<AudioClip>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700548B RID: 21643
			// (get) Token: 0x060102B5 RID: 66229 RVA: 0x003C5204 File Offset: 0x003C3404
			// (set) Token: 0x060102B6 RID: 66230 RVA: 0x0008CB9F File Offset: 0x0008AD9F
			public UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__4);
					return new UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogAction._LoadDialogActionData_d__16.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A410 RID: 42000
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A411 RID: 42001
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A412 RID: 42002
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A413 RID: 42003
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400A414 RID: 42004
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A415 RID: 42005
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400A416 RID: 42006
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400A417 RID: 42007
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x0400A418 RID: 42008
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A419 RID: 42009
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E01 RID: 3585
		private sealed class MethodInfoStoreGeneric_LoadAssetAllowNull_Private_UniTask_1_IAssetHandle_1_T_AssetReferenceT_1_T_0<T>
		{
			// Token: 0x0400A41A RID: 42010
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogAction.NativeMethodInfoPtr_LoadAssetAllowNull_Private_UniTask_1_IAssetHandle_1_T_AssetReferenceT_1_T_0, Il2CppClassPointerStore<DialogAction>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
