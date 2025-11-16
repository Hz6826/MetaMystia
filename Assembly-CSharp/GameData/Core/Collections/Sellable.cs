using System;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.Core.Collections
{
	// Token: 0x02000244 RID: 580
	[Serializable]
	public class Sellable : TradableObjectBase
	{
		// Token: 0x0600484D RID: 18509 RVA: 0x0019908C File Offset: 0x0019728C
		// Note: this type is marked as 'beforefieldinit'.
		static Sellable()
		{
			Il2CppClassPointerStore<Sellable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Sellable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sellable>.NativeClassPtr);
			Sellable.NativeFieldInfoPtr_isCollab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "isCollab");
			Sellable.NativeFieldInfoPtr_banTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "banTags");
			Sellable.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "type");
			Sellable.NativeFieldInfoPtr_additiveTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "additiveTags");
			Sellable.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "modifier");
			Sellable.NativeFieldInfoPtr__RunTimeGUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "<RunTimeGUID>k__BackingField");
			Sellable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_SellableType_List_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677745);
			Sellable.NativeMethodInfoPtr_get_IsCollab_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677746);
			Sellable.NativeMethodInfoPtr_get_BanTags_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677747);
			Sellable.NativeMethodInfoPtr_get_Modifier_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677748);
			Sellable.NativeMethodInfoPtr_set_Modifier_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677749);
			Sellable.NativeMethodInfoPtr_get_RunTimeGUID_Public_get_Nullable_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677750);
			Sellable.NativeMethodInfoPtr_set_RunTimeGUID_Public_set_Void_Nullable_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677751);
			Sellable.NativeMethodInfoPtr_get_Altered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677752);
			Sellable.NativeMethodInfoPtr_get_HasModifier_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677753);
			Sellable.NativeMethodInfoPtr_get_PriceTag_Private_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677754);
			Sellable.NativeMethodInfoPtr_get_AdditiveTags_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677755);
			Sellable.NativeMethodInfoPtr_get_Tags_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677756);
			Sellable.NativeMethodInfoPtr_get_Type_Public_get_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677757);
			Sellable.NativeMethodInfoPtr_set_Type_Public_set_Void_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677758);
			Sellable.NativeMethodInfoPtr_GetPopTag_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677759);
			Sellable.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677760);
			Sellable.NativeMethodInfoPtr_AddToTags_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677761);
			Sellable.NativeMethodInfoPtr_GetTagDiff_Public_Void_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677762);
			Sellable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677763);
			Sellable.NativeMethodInfoPtr_Duplicate_Public_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677764);
			Sellable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677765);
			Sellable.NativeMethodInfoPtr_OnGetObjectType_Protected_Virtual_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable>.NativeClassPtr, 100677766);
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x001992EC File Offset: 0x001974EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189985, XrefRangeEnd = 189994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable(int id, int baseValue, int level, Il2CppStructArray<int> tags, Il2CppStructArray<int> banTags, Sellable.SellableType type, List<int> additiveTags, bool isCollab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sellable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(banTags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additiveTags);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCollab;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_SellableType_List_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x001993A4 File Offset: 0x001975A4
		public unsafe bool IsCollab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_IsCollab_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06004850 RID: 18512 RVA: 0x001993E0 File Offset: 0x001975E0
		public unsafe Il2CppStructArray<int> BanTags
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_BanTags_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00199420 File Offset: 0x00197620
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x00199460 File Offset: 0x00197660
		public unsafe Il2CppStructArray<int> Modifier
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 189997, RefRangeEnd = 190018, XrefRangeStart = 189994, XrefRangeEnd = 189997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_Modifier_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157648, RefRangeEnd = 157649, XrefRangeStart = 157648, XrefRangeEnd = 157649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_set_Modifier_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x001994A4 File Offset: 0x001976A4
		// (set) Token: 0x06004854 RID: 18516 RVA: 0x001994DC File Offset: 0x001976DC
		public unsafe Nullable<Guid> RunTimeGUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_RunTimeGUID_Public_get_Nullable_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<Guid>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_set_RunTimeGUID_Public_set_Void_Nullable_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x00199524 File Offset: 0x00197724
		public unsafe bool Altered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190022, RefRangeEnd = 190023, XrefRangeStart = 190018, XrefRangeEnd = 190022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_Altered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x00199560 File Offset: 0x00197760
		public unsafe bool HasModifier
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 190026, RefRangeEnd = 190052, XrefRangeStart = 190023, XrefRangeEnd = 190026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_HasModifier_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x0019959C File Offset: 0x0019779C
		public unsafe List<int> PriceTag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190052, XrefRangeEnd = 190067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_PriceTag_Private_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x001995DC File Offset: 0x001977DC
		public unsafe List<int> AdditiveTags
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 190074, RefRangeEnd = 190082, XrefRangeStart = 190067, XrefRangeEnd = 190074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_AdditiveTags_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x0019961C File Offset: 0x0019781C
		public unsafe override Il2CppStructArray<int> Tags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190082, XrefRangeEnd = 190157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sellable.NativeMethodInfoPtr_get_Tags_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x00199668 File Offset: 0x00197868
		// (set) Token: 0x0600485B RID: 18523 RVA: 0x001996A4 File Offset: 0x001978A4
		public unsafe Sellable.SellableType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_get_Type_Public_get_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_set_Type_Public_set_Void_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x001996E4 File Offset: 0x001978E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190192, RefRangeEnd = 190193, XrefRangeStart = 190157, XrefRangeEnd = 190192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> GetPopTag(IEnumerable<int> sourceTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceTag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_GetPopTag_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00199734 File Offset: 0x00197934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190193, XrefRangeEnd = 190194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sellable.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x0019978C File Offset: 0x0019798C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 190197, RefRangeEnd = 190201, XrefRangeStart = 190194, XrefRangeEnd = 190197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToTags(int tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_AddToTags_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x001997CC File Offset: 0x001979CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190244, RefRangeEnd = 190246, XrefRangeStart = 190201, XrefRangeEnd = 190244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTagDiff(out IEnumerable<int> unchanged, out IEnumerable<int> addedTags, out IEnumerable<int> removedTags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_GetTagDiff_Public_Void_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			unchanged = ((intPtr6 == 0) ? null : new IEnumerable<int>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			addedTags = ((intPtr7 == 0) ? null : new IEnumerable<int>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			removedTags = ((intPtr8 == 0) ? null : new IEnumerable<int>(intPtr8));
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00199864 File Offset: 0x00197A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190246, XrefRangeEnd = 190247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sellable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x001998B0 File Offset: 0x00197AB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 190279, RefRangeEnd = 190286, XrefRangeStart = 190247, XrefRangeEnd = 190279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable Duplicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.NativeMethodInfoPtr_Duplicate_Public_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x001998F0 File Offset: 0x00197AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190286, XrefRangeEnd = 190346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sellable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00199934 File Offset: 0x00197B34
		[CallerCount(0)]
		public unsafe override SchedulerNode.Reward.ObjectType OnGetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sellable.NativeMethodInfoPtr_OnGetObjectType_Protected_Virtual_ObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x000252CF File Offset: 0x000234CF
		public Sellable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x0019997C File Offset: 0x00197B7C
		// (set) Token: 0x06004866 RID: 18534 RVA: 0x000252D8 File Offset: 0x000234D8
		public unsafe bool isCollab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_isCollab);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_isCollab)) = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x001999A4 File Offset: 0x00197BA4
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x000252F3 File Offset: 0x000234F3
		public unsafe Il2CppStructArray<int> banTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_banTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_banTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x001999D4 File Offset: 0x00197BD4
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x00025312 File Offset: 0x00023512
		public unsafe Sellable.SellableType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x001999FC File Offset: 0x00197BFC
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x0002532D File Offset: 0x0002352D
		public unsafe List<int> additiveTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_additiveTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_additiveTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x00199A2C File Offset: 0x00197C2C
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x0002534C File Offset: 0x0002354C
		public unsafe Il2CppStructArray<int> modifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_modifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x00199A5C File Offset: 0x00197C5C
		// (set) Token: 0x06004870 RID: 18544 RVA: 0x0002536B File Offset: 0x0002356B
		public Nullable<Guid> _RunTimeGUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr__RunTimeGUID_k__BackingField);
				return new Nullable<Guid>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Guid>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.NativeFieldInfoPtr__RunTimeGUID_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Guid>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeFieldInfoPtr_isCollab;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeFieldInfoPtr_banTags;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeFieldInfoPtr_additiveTags;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeFieldInfoPtr_modifier;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeFieldInfoPtr__RunTimeGUID_k__BackingField;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_SellableType_List_1_Int32_Boolean_0;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCollab_Public_get_Boolean_0;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeMethodInfoPtr_get_BanTags_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeMethodInfoPtr_get_Modifier_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeMethodInfoPtr_set_Modifier_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr_get_RunTimeGUID_Public_get_Nullable_1_Guid_0;

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeMethodInfoPtr_set_RunTimeGUID_Public_set_Void_Nullable_1_Guid_0;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeMethodInfoPtr_get_Altered_Public_get_Boolean_0;

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeMethodInfoPtr_get_HasModifier_Public_get_Boolean_0;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceTag_Private_get_List_1_Int32_0;

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveTags_Public_get_List_1_Int32_0;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_SellableType_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_SellableType_0;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_GetPopTag_Private_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;

		// Token: 0x040031BE RID: 12734
		private static readonly IntPtr NativeMethodInfoPtr_AddToTags_Public_Void_Int32_0;

		// Token: 0x040031BF RID: 12735
		private static readonly IntPtr NativeMethodInfoPtr_GetTagDiff_Public_Void_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_0;

		// Token: 0x040031C0 RID: 12736
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x040031C1 RID: 12737
		private static readonly IntPtr NativeMethodInfoPtr_Duplicate_Public_Sellable_0;

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr_OnGetObjectType_Protected_Virtual_ObjectType_0;

		// Token: 0x02000ABE RID: 2750
		public enum SellableType
		{
			// Token: 0x0400846B RID: 33899
			Food,
			// Token: 0x0400846C RID: 33900
			Beverage
		}

		// Token: 0x02000ABF RID: 2751
		[ObfuscatedName("GameData.Core.Collections.Sellable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CDEC RID: 52716 RVA: 0x0032C17C File Offset: 0x0032A37C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr);
				Sellable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9");
				Sellable.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__27_1");
				Sellable.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__27_0");
				Sellable.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__34_0");
				Sellable.__c.NativeFieldInfoPtr___9__37_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__37_2");
				Sellable.__c.NativeFieldInfoPtr___9__37_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__37_3");
				Sellable.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__37_0");
				Sellable.__c.NativeFieldInfoPtr___9__37_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, "<>9__37_1");
				Sellable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677768);
				Sellable.__c.NativeMethodInfoPtr__get_Tags_b__27_1_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677769);
				Sellable.__c.NativeMethodInfoPtr__get_Tags_b__27_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677770);
				Sellable.__c.NativeMethodInfoPtr__GetTagDiff_b__34_0_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677771);
				Sellable.__c.NativeMethodInfoPtr__ToString_b__37_2_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677772);
				Sellable.__c.NativeMethodInfoPtr__ToString_b__37_3_Internal_IEnumerable_1_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677773);
				Sellable.__c.NativeMethodInfoPtr__ToString_b__37_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677774);
				Sellable.__c.NativeMethodInfoPtr__ToString_b__37_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr, 100677775);
			}

			// Token: 0x0600CDED RID: 52717 RVA: 0x0032C2E8 File Offset: 0x0032A4E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sellable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDEE RID: 52718 RVA: 0x0032C324 File Offset: 0x0032A524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _get_Tags_b__27_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__get_Tags_b__27_1_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CDEF RID: 52719 RVA: 0x0032C370 File Offset: 0x0032A570
			[CallerCount(0)]
			public unsafe bool _get_Tags_b__27_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__get_Tags_b__27_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDF0 RID: 52720 RVA: 0x0032C3BC File Offset: 0x0032A5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GetTagDiff_b__34_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__GetTagDiff_b__34_0_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CDF1 RID: 52721 RVA: 0x0032C408 File Offset: 0x0032A608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _ToString_b__37_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__ToString_b__37_2_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600CDF2 RID: 52722 RVA: 0x0032C454 File Offset: 0x0032A654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189978, XrefRangeEnd = 189979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _ToString_b__37_3(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__ToString_b__37_3_Internal_IEnumerable_1_Int32_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CDF3 RID: 52723 RVA: 0x0032C4A4 File Offset: 0x0032A6A4
			[CallerCount(0)]
			public unsafe int _ToString_b__37_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__ToString_b__37_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDF4 RID: 52724 RVA: 0x0032C4F0 File Offset: 0x0032A6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__37_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c.NativeMethodInfoPtr__ToString_b__37_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CDF5 RID: 52725 RVA: 0x0006E4E2 File Offset: 0x0006C6E2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F2 RID: 17138
			// (get) Token: 0x0600CDF6 RID: 52726 RVA: 0x0032C534 File Offset: 0x0032A734
			// (set) Token: 0x0600CDF7 RID: 52727 RVA: 0x0006E4EB File Offset: 0x0006C6EB
			public unsafe static Sellable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F3 RID: 17139
			// (get) Token: 0x0600CDF8 RID: 52728 RVA: 0x0032C55C File Offset: 0x0032A75C
			// (set) Token: 0x0600CDF9 RID: 52729 RVA: 0x0006E4FD File Offset: 0x0006C6FD
			public unsafe static Func<int, IEnumerable<int>> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F4 RID: 17140
			// (get) Token: 0x0600CDFA RID: 52730 RVA: 0x0032C584 File Offset: 0x0032A784
			// (set) Token: 0x0600CDFB RID: 52731 RVA: 0x0006E50F File Offset: 0x0006C70F
			public unsafe static Func<int, bool> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F5 RID: 17141
			// (get) Token: 0x0600CDFC RID: 52732 RVA: 0x0032C5AC File Offset: 0x0032A7AC
			// (set) Token: 0x0600CDFD RID: 52733 RVA: 0x0006E521 File Offset: 0x0006C721
			public unsafe static Func<int, IEnumerable<int>> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F6 RID: 17142
			// (get) Token: 0x0600CDFE RID: 52734 RVA: 0x0032C5D4 File Offset: 0x0032A7D4
			// (set) Token: 0x0600CDFF RID: 52735 RVA: 0x0006E533 File Offset: 0x0006C733
			public unsafe static Func<int, Ingredient> __9__37_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__37_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__37_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F7 RID: 17143
			// (get) Token: 0x0600CE00 RID: 52736 RVA: 0x0032C5FC File Offset: 0x0032A7FC
			// (set) Token: 0x0600CE01 RID: 52737 RVA: 0x0006E545 File Offset: 0x0006C745
			public unsafe static Func<Ingredient, IEnumerable<int>> __9__37_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__37_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__37_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F8 RID: 17144
			// (get) Token: 0x0600CE02 RID: 52738 RVA: 0x0032C624 File Offset: 0x0032A824
			// (set) Token: 0x0600CE03 RID: 52739 RVA: 0x0006E557 File Offset: 0x0006C757
			public unsafe static Func<int, int> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F9 RID: 17145
			// (get) Token: 0x0600CE04 RID: 52740 RVA: 0x0032C64C File Offset: 0x0032A84C
			// (set) Token: 0x0600CE05 RID: 52741 RVA: 0x0006E569 File Offset: 0x0006C769
			public unsafe static Func<int, string> __9__37_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sellable.__c.NativeFieldInfoPtr___9__37_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sellable.__c.NativeFieldInfoPtr___9__37_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400846D RID: 33901
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400846E RID: 33902
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x0400846F RID: 33903
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04008470 RID: 33904
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04008471 RID: 33905
			private static readonly IntPtr NativeFieldInfoPtr___9__37_2;

			// Token: 0x04008472 RID: 33906
			private static readonly IntPtr NativeFieldInfoPtr___9__37_3;

			// Token: 0x04008473 RID: 33907
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x04008474 RID: 33908
			private static readonly IntPtr NativeFieldInfoPtr___9__37_1;

			// Token: 0x04008475 RID: 33909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008476 RID: 33910
			private static readonly IntPtr NativeMethodInfoPtr__get_Tags_b__27_1_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04008477 RID: 33911
			private static readonly IntPtr NativeMethodInfoPtr__get_Tags_b__27_0_Internal_Boolean_Int32_0;

			// Token: 0x04008478 RID: 33912
			private static readonly IntPtr NativeMethodInfoPtr__GetTagDiff_b__34_0_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04008479 RID: 33913
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__37_2_Internal_Ingredient_Int32_0;

			// Token: 0x0400847A RID: 33914
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__37_3_Internal_IEnumerable_1_Int32_Ingredient_0;

			// Token: 0x0400847B RID: 33915
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__37_0_Internal_Int32_Int32_0;

			// Token: 0x0400847C RID: 33916
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__37_1_Internal_String_Int32_0;
		}

		// Token: 0x02000AC0 RID: 2752
		[ObfuscatedName("GameData.Core.Collections.Sellable+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Object
		{
			// Token: 0x0600CE06 RID: 52742 RVA: 0x0032C674 File Offset: 0x0032A874
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sellable>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr);
				Sellable.__c__DisplayClass31_0.NativeFieldInfoPtr_sourceTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr, "sourceTag");
				Sellable.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr, 100677776);
				Sellable.__c__DisplayClass31_0.NativeMethodInfoPtr__GetPopTag_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr, 100677777);
				Sellable.__c__DisplayClass31_0.NativeMethodInfoPtr__GetPopTag_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr, 100677778);
			}

			// Token: 0x0600CE07 RID: 52743 RVA: 0x0032C6F0 File Offset: 0x0032A8F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sellable.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE08 RID: 52744 RVA: 0x0032C72C File Offset: 0x0032A92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189979, XrefRangeEnd = 189982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPopTag_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c__DisplayClass31_0.NativeMethodInfoPtr__GetPopTag_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE09 RID: 52745 RVA: 0x0032C778 File Offset: 0x0032A978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189982, XrefRangeEnd = 189985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPopTag_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sellable.__c__DisplayClass31_0.NativeMethodInfoPtr__GetPopTag_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE0A RID: 52746 RVA: 0x0006E57B File Offset: 0x0006C77B
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FA RID: 17146
			// (get) Token: 0x0600CE0B RID: 52747 RVA: 0x0032C7C4 File Offset: 0x0032A9C4
			// (set) Token: 0x0600CE0C RID: 52748 RVA: 0x0006E584 File Offset: 0x0006C784
			public unsafe IEnumerable<int> sourceTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.__c__DisplayClass31_0.NativeFieldInfoPtr_sourceTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sellable.__c__DisplayClass31_0.NativeFieldInfoPtr_sourceTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400847D RID: 33917
			private static readonly IntPtr NativeFieldInfoPtr_sourceTag;

			// Token: 0x0400847E RID: 33918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400847F RID: 33919
			private static readonly IntPtr NativeMethodInfoPtr__GetPopTag_b__0_Internal_Boolean_Int32_0;

			// Token: 0x04008480 RID: 33920
			private static readonly IntPtr NativeMethodInfoPtr__GetPopTag_b__1_Internal_Boolean_Int32_0;
		}
	}
}
