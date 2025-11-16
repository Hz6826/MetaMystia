using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D5 RID: 725
	public class FlandreHomeFurnitureProfile : ScriptableObject
	{
		// Token: 0x06005971 RID: 22897 RVA: 0x001CABF0 File Offset: 0x001C8DF0
		// Note: this type is marked as 'beforefieldinit'.
		static FlandreHomeFurnitureProfile()
		{
			Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "FlandreHomeFurnitureProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr);
			FlandreHomeFurnitureProfile.NativeFieldInfoPtr_flandreHomeFurnitures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr, "flandreHomeFurnitures");
			FlandreHomeFurnitureProfile.NativeFieldInfoPtr_texture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr, "texture2D");
			FlandreHomeFurnitureProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr, 100681303);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x001CAC5C File Offset: 0x001C8E5C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlandreHomeFurnitureProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x0003045E File Offset: 0x0002E65E
		public FlandreHomeFurnitureProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06005974 RID: 22900 RVA: 0x001CAC98 File Offset: 0x001C8E98
		// (set) Token: 0x06005975 RID: 22901 RVA: 0x00030467 File Offset: 0x0002E667
		public unsafe Il2CppReferenceArray<FlandreHomeFurnitureProfile.FlandreHomeFurniture> flandreHomeFurnitures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.NativeFieldInfoPtr_flandreHomeFurnitures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.NativeFieldInfoPtr_flandreHomeFurnitures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06005976 RID: 22902 RVA: 0x001CACC8 File Offset: 0x001C8EC8
		// (set) Token: 0x06005977 RID: 22903 RVA: 0x00030486 File Offset: 0x0002E686
		public unsafe Texture2D texture2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.NativeFieldInfoPtr_texture2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.NativeFieldInfoPtr_texture2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeFieldInfoPtr_flandreHomeFurnitures;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeFieldInfoPtr_texture2D;

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C9D RID: 3229
		[Serializable]
		public sealed class FlandreHomeFurniture : ValueType
		{
			// Token: 0x0600E7D0 RID: 59344 RVA: 0x0037872C File Offset: 0x0037692C
			// Note: this type is marked as 'beforefieldinit'.
			static FlandreHomeFurniture()
			{
				Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreHomeFurnitureProfile>.NativeClassPtr, "FlandreHomeFurniture");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "id");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_labelInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "labelInEditor");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_placement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "placement");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "points");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_furnitureObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "furnitureObject");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_previewImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "previewImage");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_positionInShopUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "positionInShopUI");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_maxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "maxNum");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "price");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_furnitureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, "furnitureType");
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Placement_Il2CppStructArray_1_Vector2Int_GameObject_Sprite_Vector2_Int32_Int32_FurnitureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681304);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_ID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681305);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_LabelInEditor_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681306);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_PlacementType_Public_get_Placement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681307);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_Points_Public_get_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681308);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_FurnitureObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681309);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_PreviewImage_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681310);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_PositionInShopUI_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681311);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_MaxNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681312);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_Price_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681313);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_FurnitureTypes_Public_get_FurnitureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681314);
				FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, 100681315);
			}

			// Token: 0x0600E7D1 RID: 59345 RVA: 0x00378910 File Offset: 0x00376B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219167, XrefRangeEnd = 219171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FlandreHomeFurniture(int id, string labelInEditor, FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement, Il2CppStructArray<Vector2Int> points, GameObject furnitureObject, Sprite previewImage, Vector2 positionInShopUI, int maxNum, int price, FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType furnitureType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(labelInEditor);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref placement;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(furnitureObject);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previewImage);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionInShopUI;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxNum;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref furnitureType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Placement_Il2CppStructArray_1_Vector2Int_GameObject_Sprite_Vector2_Int32_Int32_FurnitureType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B53 RID: 19283
			// (get) Token: 0x0600E7D2 RID: 59346 RVA: 0x003789F0 File Offset: 0x00376BF0
			public unsafe int ID
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_ID_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B54 RID: 19284
			// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x00378A34 File Offset: 0x00376C34
			public unsafe string LabelInEditor
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_LabelInEditor_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004B55 RID: 19285
			// (get) Token: 0x0600E7D4 RID: 59348 RVA: 0x00378A70 File Offset: 0x00376C70
			public unsafe FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement PlacementType
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_PlacementType_Public_get_Placement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B56 RID: 19286
			// (get) Token: 0x0600E7D5 RID: 59349 RVA: 0x00378AB4 File Offset: 0x00376CB4
			public unsafe Il2CppStructArray<Vector2Int> Points
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_Points_Public_get_Il2CppStructArray_1_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B57 RID: 19287
			// (get) Token: 0x0600E7D6 RID: 59350 RVA: 0x00378AF8 File Offset: 0x00376CF8
			public unsafe GameObject FurnitureObject
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_FurnitureObject_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}
			}

			// Token: 0x17004B58 RID: 19288
			// (get) Token: 0x0600E7D7 RID: 59351 RVA: 0x00378B3C File Offset: 0x00376D3C
			public unsafe Sprite PreviewImage
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_PreviewImage_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
			}

			// Token: 0x17004B59 RID: 19289
			// (get) Token: 0x0600E7D8 RID: 59352 RVA: 0x00378B80 File Offset: 0x00376D80
			public unsafe Vector2 PositionInShopUI
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_PositionInShopUI_Public_get_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B5A RID: 19290
			// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x00378BC4 File Offset: 0x00376DC4
			public unsafe int MaxNum
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_MaxNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B5B RID: 19291
			// (get) Token: 0x0600E7DA RID: 59354 RVA: 0x00378C08 File Offset: 0x00376E08
			public unsafe int Price
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_Price_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004B5C RID: 19292
			// (get) Token: 0x0600E7DB RID: 59355 RVA: 0x00378C4C File Offset: 0x00376E4C
			public unsafe FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType FurnitureTypes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_get_FurnitureTypes_Public_get_FurnitureType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E7DC RID: 59356 RVA: 0x00378C90 File Offset: 0x00376E90
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219173, RefRangeEnd = 219175, XrefRangeStart = 219171, XrefRangeEnd = 219173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E7DD RID: 59357 RVA: 0x0007BDD0 File Offset: 0x00079FD0
			public FlandreHomeFurniture(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E7DE RID: 59358 RVA: 0x0007BDD9 File Offset: 0x00079FD9
			public FlandreHomeFurniture() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr))
			{
			}

			// Token: 0x17004B49 RID: 19273
			// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x00378CCC File Offset: 0x00376ECC
			// (set) Token: 0x0600E7E0 RID: 59360 RVA: 0x0007BDEB File Offset: 0x00079FEB
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17004B4A RID: 19274
			// (get) Token: 0x0600E7E1 RID: 59361 RVA: 0x00378CF4 File Offset: 0x00376EF4
			// (set) Token: 0x0600E7E2 RID: 59362 RVA: 0x0007BE06 File Offset: 0x0007A006
			public unsafe string labelInEditor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_labelInEditor);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_labelInEditor), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B4B RID: 19275
			// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x00378D1C File Offset: 0x00376F1C
			// (set) Token: 0x0600E7E4 RID: 59364 RVA: 0x0007BE25 File Offset: 0x0007A025
			public unsafe FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_placement);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_placement)) = value;
				}
			}

			// Token: 0x17004B4C RID: 19276
			// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x00378D44 File Offset: 0x00376F44
			// (set) Token: 0x0600E7E6 RID: 59366 RVA: 0x0007BE40 File Offset: 0x0007A040
			public unsafe Il2CppStructArray<Vector2Int> points
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_points);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B4D RID: 19277
			// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x00378D74 File Offset: 0x00376F74
			// (set) Token: 0x0600E7E8 RID: 59368 RVA: 0x0007BE5F File Offset: 0x0007A05F
			public unsafe GameObject furnitureObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_furnitureObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_furnitureObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B4E RID: 19278
			// (get) Token: 0x0600E7E9 RID: 59369 RVA: 0x00378DA4 File Offset: 0x00376FA4
			// (set) Token: 0x0600E7EA RID: 59370 RVA: 0x0007BE7E File Offset: 0x0007A07E
			public unsafe Sprite previewImage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_previewImage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_previewImage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B4F RID: 19279
			// (get) Token: 0x0600E7EB RID: 59371 RVA: 0x00378DD4 File Offset: 0x00376FD4
			// (set) Token: 0x0600E7EC RID: 59372 RVA: 0x0007BE9D File Offset: 0x0007A09D
			public unsafe Vector2 positionInShopUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_positionInShopUI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_positionInShopUI)) = value;
				}
			}

			// Token: 0x17004B50 RID: 19280
			// (get) Token: 0x0600E7ED RID: 59373 RVA: 0x00378DFC File Offset: 0x00376FFC
			// (set) Token: 0x0600E7EE RID: 59374 RVA: 0x0007BEB8 File Offset: 0x0007A0B8
			public unsafe int maxNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_maxNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_maxNum)) = value;
				}
			}

			// Token: 0x17004B51 RID: 19281
			// (get) Token: 0x0600E7EF RID: 59375 RVA: 0x00378E24 File Offset: 0x00377024
			// (set) Token: 0x0600E7F0 RID: 59376 RVA: 0x0007BED3 File Offset: 0x0007A0D3
			public unsafe int price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x17004B52 RID: 19282
			// (get) Token: 0x0600E7F1 RID: 59377 RVA: 0x00378E4C File Offset: 0x0037704C
			// (set) Token: 0x0600E7F2 RID: 59378 RVA: 0x0007BEEE File Offset: 0x0007A0EE
			public unsafe FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType furnitureType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_furnitureType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeFurnitureProfile.FlandreHomeFurniture.NativeFieldInfoPtr_furnitureType)) = value;
				}
			}

			// Token: 0x040093EF RID: 37871
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040093F0 RID: 37872
			private static readonly IntPtr NativeFieldInfoPtr_labelInEditor;

			// Token: 0x040093F1 RID: 37873
			private static readonly IntPtr NativeFieldInfoPtr_placement;

			// Token: 0x040093F2 RID: 37874
			private static readonly IntPtr NativeFieldInfoPtr_points;

			// Token: 0x040093F3 RID: 37875
			private static readonly IntPtr NativeFieldInfoPtr_furnitureObject;

			// Token: 0x040093F4 RID: 37876
			private static readonly IntPtr NativeFieldInfoPtr_previewImage;

			// Token: 0x040093F5 RID: 37877
			private static readonly IntPtr NativeFieldInfoPtr_positionInShopUI;

			// Token: 0x040093F6 RID: 37878
			private static readonly IntPtr NativeFieldInfoPtr_maxNum;

			// Token: 0x040093F7 RID: 37879
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x040093F8 RID: 37880
			private static readonly IntPtr NativeFieldInfoPtr_furnitureType;

			// Token: 0x040093F9 RID: 37881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Placement_Il2CppStructArray_1_Vector2Int_GameObject_Sprite_Vector2_Int32_Int32_FurnitureType_0;

			// Token: 0x040093FA RID: 37882
			private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_get_Int32_0;

			// Token: 0x040093FB RID: 37883
			private static readonly IntPtr NativeMethodInfoPtr_get_LabelInEditor_Public_get_String_0;

			// Token: 0x040093FC RID: 37884
			private static readonly IntPtr NativeMethodInfoPtr_get_PlacementType_Public_get_Placement_0;

			// Token: 0x040093FD RID: 37885
			private static readonly IntPtr NativeMethodInfoPtr_get_Points_Public_get_Il2CppStructArray_1_Vector2Int_0;

			// Token: 0x040093FE RID: 37886
			private static readonly IntPtr NativeMethodInfoPtr_get_FurnitureObject_Public_get_GameObject_0;

			// Token: 0x040093FF RID: 37887
			private static readonly IntPtr NativeMethodInfoPtr_get_PreviewImage_Public_get_Sprite_0;

			// Token: 0x04009400 RID: 37888
			private static readonly IntPtr NativeMethodInfoPtr_get_PositionInShopUI_Public_get_Vector2_0;

			// Token: 0x04009401 RID: 37889
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxNum_Public_get_Int32_0;

			// Token: 0x04009402 RID: 37890
			private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Int32_0;

			// Token: 0x04009403 RID: 37891
			private static readonly IntPtr NativeMethodInfoPtr_get_FurnitureTypes_Public_get_FurnitureType_0;

			// Token: 0x04009404 RID: 37892
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0200105D RID: 4189
			public enum FurnitureType
			{
				// Token: 0x0400B4ED RID: 46317
				Carpet,
				// Token: 0x0400B4EE RID: 46318
				Cabinet,
				// Token: 0x0400B4EF RID: 46319
				Table,
				// Token: 0x0400B4F0 RID: 46320
				Chair,
				// Token: 0x0400B4F1 RID: 46321
				Bed,
				// Token: 0x0400B4F2 RID: 46322
				Object,
				// Token: 0x0400B4F3 RID: 46323
				Paint
			}

			// Token: 0x0200105E RID: 4190
			public enum Placement
			{
				// Token: 0x0400B4F5 RID: 46325
				Ground,
				// Token: 0x0400B4F6 RID: 46326
				Wall,
				// Token: 0x0400B4F7 RID: 46327
				Carpet
			}
		}
	}
}
