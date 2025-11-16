using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x020002C8 RID: 712
	public class ClothesProfile : ScriptableObject
	{
		// Token: 0x06005862 RID: 22626 RVA: 0x001C86B8 File Offset: 0x001C68B8
		// Note: this type is marked as 'beforefieldinit'.
		static ClothesProfile()
		{
			Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "ClothesProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr);
			ClothesProfile.NativeFieldInfoPtr_clothesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr, "clothesIndex");
			ClothesProfile.NativeFieldInfoPtr_previewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr, "previewName");
			ClothesProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr, 100681254);
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x001C8724 File Offset: 0x001C6924
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothesProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0002F5E1 File Offset: 0x0002D7E1
		public ClothesProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x001C8760 File Offset: 0x001C6960
		// (set) Token: 0x06005866 RID: 22630 RVA: 0x0002F5EA File Offset: 0x0002D7EA
		public unsafe Il2CppReferenceArray<ClothesProfile.Clothes> clothesIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.NativeFieldInfoPtr_clothesIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClothesProfile.Clothes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.NativeFieldInfoPtr_clothesIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x001C8790 File Offset: 0x001C6990
		// (set) Token: 0x06005868 RID: 22632 RVA: 0x0002F609 File Offset: 0x0002D809
		public unsafe string previewName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.NativeFieldInfoPtr_previewName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.NativeFieldInfoPtr_previewName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B34 RID: 15156
		private static readonly IntPtr NativeFieldInfoPtr_clothesIndex;

		// Token: 0x04003B35 RID: 15157
		private static readonly IntPtr NativeFieldInfoPtr_previewName;

		// Token: 0x04003B36 RID: 15158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C90 RID: 3216
		[Serializable]
		public class Clothes : Il2CppSystem.Object
		{
			// Token: 0x0600E6F9 RID: 59129 RVA: 0x00376694 File Offset: 0x00374894
			// Note: this type is marked as 'beforefieldinit'.
			static Clothes()
			{
				Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothesProfile>.NativeClassPtr, "Clothes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr);
				ClothesProfile.Clothes.NativeFieldInfoPtr_skinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "skinIndex");
				ClothesProfile.Clothes.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "index");
				ClothesProfile.Clothes.NativeFieldInfoPtr_izakayaSkinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "izakayaSkinIndex");
				ClothesProfile.Clothes.NativeFieldInfoPtr_m_OverrideVisualAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "m_OverrideVisualAsset");
				ClothesProfile.Clothes.NativeFieldInfoPtr_m_OverrideDynamicVisualAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "m_OverrideDynamicVisualAsset");
				ClothesProfile.Clothes.NativeFieldInfoPtr_frameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "frameTime");
				ClothesProfile.Clothes.NativeFieldInfoPtr_izkayaHorizontalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "izkayaHorizontalOffset");
				ClothesProfile.Clothes.NativeFieldInfoPtr_notebookHorizontalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "notebookHorizontalOffset");
				ClothesProfile.Clothes.NativeFieldInfoPtr_notebookVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "notebookVerticalOffset");
				ClothesProfile.Clothes.NativeFieldInfoPtr_notebookUITitleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, "notebookUITitleOffset");
				ClothesProfile.Clothes.NativeMethodInfoPtr_get_IsValidVisual_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681255);
				ClothesProfile.Clothes.NativeMethodInfoPtr_get_IsDynamicVisualPortrayal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681256);
				ClothesProfile.Clothes.NativeMethodInfoPtr_LoadOverrideVisual_Public_UniTask_1_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681257);
				ClothesProfile.Clothes.NativeMethodInfoPtr_LoadOverrideDynamicVisual_Public_UniTask_1_IAssetHandleArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681258);
				ClothesProfile.Clothes.NativeMethodInfoPtr_LoadFirstOverrideDynamicVisual_Public_UniTask_1_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681259);
				ClothesProfile.Clothes.NativeMethodInfoPtr_ChangeTypeToInt_Public_Int32_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681260);
				ClothesProfile.Clothes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr, 100681261);
			}

			// Token: 0x17004AED RID: 19181
			// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x00376814 File Offset: 0x00374A14
			public unsafe bool IsValidVisual
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr_get_IsValidVisual_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004AEE RID: 19182
			// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x00376850 File Offset: 0x00374A50
			public unsafe bool IsDynamicVisualPortrayal
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218713, RefRangeEnd = 218714, XrefRangeStart = 218713, XrefRangeEnd = 218713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr_get_IsDynamicVisualPortrayal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E6FC RID: 59132 RVA: 0x0037688C File Offset: 0x00374A8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 218721, RefRangeEnd = 218722, XrefRangeStart = 218714, XrefRangeEnd = 218721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<IAssetHandle<Sprite>> LoadOverrideVisual()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr_LoadOverrideVisual_Public_UniTask_1_IAssetHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<IAssetHandle<Sprite>>(pointer);
			}

			// Token: 0x0600E6FD RID: 59133 RVA: 0x003768C4 File Offset: 0x00374AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218722, XrefRangeEnd = 218729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<IAssetHandleArray<Sprite>> LoadOverrideDynamicVisual()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr_LoadOverrideDynamicVisual_Public_UniTask_1_IAssetHandleArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<IAssetHandleArray<Sprite>>(pointer);
			}

			// Token: 0x0600E6FE RID: 59134 RVA: 0x003768FC File Offset: 0x00374AFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 218736, RefRangeEnd = 218737, XrefRangeStart = 218729, XrefRangeEnd = 218736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<IAssetHandle<Sprite>> LoadFirstOverrideDynamicVisual()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr_LoadFirstOverrideDynamicVisual_Public_UniTask_1_IAssetHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<IAssetHandle<Sprite>>(pointer);
			}

			// Token: 0x0600E6FF RID: 59135 RVA: 0x00376934 File Offset: 0x00374B34
			[CallerCount(0)]
			public unsafe int ChangeTypeToInt(CharacterSkinSets.SkinSelectionInfo skin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref skin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr_ChangeTypeToInt_Public_Int32_SkinSelectionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E700 RID: 59136 RVA: 0x00376980 File Offset: 0x00374B80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Clothes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothesProfile.Clothes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesProfile.Clothes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E701 RID: 59137 RVA: 0x0007B432 File Offset: 0x00079632
			public Clothes(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AE3 RID: 19171
			// (get) Token: 0x0600E702 RID: 59138 RVA: 0x003769BC File Offset: 0x00374BBC
			// (set) Token: 0x0600E703 RID: 59139 RVA: 0x0007B43B File Offset: 0x0007963B
			public unsafe CharacterSkinSets.SkinSelectionInfo skinIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_skinIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_skinIndex)) = value;
				}
			}

			// Token: 0x17004AE4 RID: 19172
			// (get) Token: 0x0600E704 RID: 59140 RVA: 0x003769E4 File Offset: 0x00374BE4
			// (set) Token: 0x0600E705 RID: 59141 RVA: 0x0007B456 File Offset: 0x00079656
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004AE5 RID: 19173
			// (get) Token: 0x0600E706 RID: 59142 RVA: 0x00376A0C File Offset: 0x00374C0C
			// (set) Token: 0x0600E707 RID: 59143 RVA: 0x0007B471 File Offset: 0x00079671
			public unsafe int izakayaSkinIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_izakayaSkinIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_izakayaSkinIndex)) = value;
				}
			}

			// Token: 0x17004AE6 RID: 19174
			// (get) Token: 0x0600E708 RID: 59144 RVA: 0x00376A34 File Offset: 0x00374C34
			// (set) Token: 0x0600E709 RID: 59145 RVA: 0x0007B48C File Offset: 0x0007968C
			public unsafe AssetReferenceSprite m_OverrideVisualAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_m_OverrideVisualAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_m_OverrideVisualAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE7 RID: 19175
			// (get) Token: 0x0600E70A RID: 59146 RVA: 0x00376A64 File Offset: 0x00374C64
			// (set) Token: 0x0600E70B RID: 59147 RVA: 0x0007B4AB File Offset: 0x000796AB
			public unsafe Il2CppReferenceArray<AssetReferenceSprite> m_OverrideDynamicVisualAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_m_OverrideDynamicVisualAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetReferenceSprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_m_OverrideDynamicVisualAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE8 RID: 19176
			// (get) Token: 0x0600E70C RID: 59148 RVA: 0x00376A94 File Offset: 0x00374C94
			// (set) Token: 0x0600E70D RID: 59149 RVA: 0x0007B4CA File Offset: 0x000796CA
			public unsafe float frameTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_frameTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_frameTime)) = value;
				}
			}

			// Token: 0x17004AE9 RID: 19177
			// (get) Token: 0x0600E70E RID: 59150 RVA: 0x00376ABC File Offset: 0x00374CBC
			// (set) Token: 0x0600E70F RID: 59151 RVA: 0x0007B4E5 File Offset: 0x000796E5
			public unsafe float izkayaHorizontalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_izkayaHorizontalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_izkayaHorizontalOffset)) = value;
				}
			}

			// Token: 0x17004AEA RID: 19178
			// (get) Token: 0x0600E710 RID: 59152 RVA: 0x00376AE4 File Offset: 0x00374CE4
			// (set) Token: 0x0600E711 RID: 59153 RVA: 0x0007B500 File Offset: 0x00079700
			public unsafe float notebookHorizontalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_notebookHorizontalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_notebookHorizontalOffset)) = value;
				}
			}

			// Token: 0x17004AEB RID: 19179
			// (get) Token: 0x0600E712 RID: 59154 RVA: 0x00376B0C File Offset: 0x00374D0C
			// (set) Token: 0x0600E713 RID: 59155 RVA: 0x0007B51B File Offset: 0x0007971B
			public unsafe float notebookVerticalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_notebookVerticalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_notebookVerticalOffset)) = value;
				}
			}

			// Token: 0x17004AEC RID: 19180
			// (get) Token: 0x0600E714 RID: 59156 RVA: 0x00376B34 File Offset: 0x00374D34
			// (set) Token: 0x0600E715 RID: 59157 RVA: 0x0007B536 File Offset: 0x00079736
			public unsafe Vector2 notebookUITitleOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_notebookUITitleOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesProfile.Clothes.NativeFieldInfoPtr_notebookUITitleOffset)) = value;
				}
			}

			// Token: 0x04009380 RID: 37760
			private static readonly IntPtr NativeFieldInfoPtr_skinIndex;

			// Token: 0x04009381 RID: 37761
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009382 RID: 37762
			private static readonly IntPtr NativeFieldInfoPtr_izakayaSkinIndex;

			// Token: 0x04009383 RID: 37763
			private static readonly IntPtr NativeFieldInfoPtr_m_OverrideVisualAsset;

			// Token: 0x04009384 RID: 37764
			private static readonly IntPtr NativeFieldInfoPtr_m_OverrideDynamicVisualAsset;

			// Token: 0x04009385 RID: 37765
			private static readonly IntPtr NativeFieldInfoPtr_frameTime;

			// Token: 0x04009386 RID: 37766
			private static readonly IntPtr NativeFieldInfoPtr_izkayaHorizontalOffset;

			// Token: 0x04009387 RID: 37767
			private static readonly IntPtr NativeFieldInfoPtr_notebookHorizontalOffset;

			// Token: 0x04009388 RID: 37768
			private static readonly IntPtr NativeFieldInfoPtr_notebookVerticalOffset;

			// Token: 0x04009389 RID: 37769
			private static readonly IntPtr NativeFieldInfoPtr_notebookUITitleOffset;

			// Token: 0x0400938A RID: 37770
			private static readonly IntPtr NativeMethodInfoPtr_get_IsValidVisual_Public_get_Boolean_0;

			// Token: 0x0400938B RID: 37771
			private static readonly IntPtr NativeMethodInfoPtr_get_IsDynamicVisualPortrayal_Public_get_Boolean_0;

			// Token: 0x0400938C RID: 37772
			private static readonly IntPtr NativeMethodInfoPtr_LoadOverrideVisual_Public_UniTask_1_IAssetHandle_1_Sprite_0;

			// Token: 0x0400938D RID: 37773
			private static readonly IntPtr NativeMethodInfoPtr_LoadOverrideDynamicVisual_Public_UniTask_1_IAssetHandleArray_1_Sprite_0;

			// Token: 0x0400938E RID: 37774
			private static readonly IntPtr NativeMethodInfoPtr_LoadFirstOverrideDynamicVisual_Public_UniTask_1_IAssetHandle_1_Sprite_0;

			// Token: 0x0400938F RID: 37775
			private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeToInt_Public_Int32_SkinSelectionInfo_0;

			// Token: 0x04009390 RID: 37776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
