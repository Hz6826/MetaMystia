using System;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections
{
	// Token: 0x0200023F RID: 575
	[Serializable]
	public class Ingredient : TradableObjectBase
	{
		// Token: 0x060047C7 RID: 18375 RVA: 0x00197140 File Offset: 0x00195340
		// Note: this type is marked as 'beforefieldinit'.
		static Ingredient()
		{
			Il2CppClassPointerStore<Ingredient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Ingredient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ingredient>.NativeClassPtr);
			Ingredient.NativeFieldInfoPtr_MEAT_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, "MEAT_TAG_ID");
			Ingredient.NativeFieldInfoPtr_SEAFOOD_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, "SEAFOOD_TAG_ID");
			Ingredient.NativeFieldInfoPtr_VEGETABLE_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, "VEGETABLE_TAG_ID");
			Ingredient.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, "prefix");
			Ingredient.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677657);
			Ingredient.NativeMethodInfoPtr_get_IsFish_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677658);
			Ingredient.NativeMethodInfoPtr_get_IsMeat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677659);
			Ingredient.NativeMethodInfoPtr_get_IsVeg_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677660);
			Ingredient.NativeMethodInfoPtr_get_Prefix_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677661);
			Ingredient.NativeMethodInfoPtr_set_Prefix_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677662);
			Ingredient.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677663);
			Ingredient.NativeMethodInfoPtr_Duplicate_Public_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677664);
			Ingredient.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677665);
			Ingredient.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677666);
			Ingredient.NativeMethodInfoPtr_OnGetObjectType_Protected_Virtual_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ingredient>.NativeClassPtr, 100677667);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0019729C File Offset: 0x0019549C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189523, XrefRangeEnd = 189524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ingredient(int id, int baseValue, int level, int prefix, Il2CppStructArray<int> tags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ingredient>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x00197320 File Offset: 0x00195520
		public unsafe bool IsFish
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 189527, RefRangeEnd = 189535, XrefRangeStart = 189524, XrefRangeEnd = 189527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr_get_IsFish_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x0019735C File Offset: 0x0019555C
		public unsafe bool IsMeat
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 189538, RefRangeEnd = 189545, XrefRangeStart = 189535, XrefRangeEnd = 189538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr_get_IsMeat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x00197398 File Offset: 0x00195598
		public unsafe bool IsVeg
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 189548, RefRangeEnd = 189556, XrefRangeStart = 189545, XrefRangeEnd = 189548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr_get_IsVeg_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x001973D4 File Offset: 0x001955D4
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x00197410 File Offset: 0x00195610
		public unsafe int Prefix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr_get_Prefix_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr_set_Prefix_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x00197450 File Offset: 0x00195650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189560, RefRangeEnd = 189561, XrefRangeStart = 189556, XrefRangeEnd = 189560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ingredient.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x0019749C File Offset: 0x0019569C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189560, RefRangeEnd = 189561, XrefRangeStart = 189560, XrefRangeEnd = 189561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ingredient Duplicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ingredient.NativeMethodInfoPtr_Duplicate_Public_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x001974DC File Offset: 0x001956DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189561, XrefRangeEnd = 189614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ingredient.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x00197520 File Offset: 0x00195720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ingredient.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x00197578 File Offset: 0x00195778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SchedulerNode.Reward.ObjectType OnGetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ingredient.NativeMethodInfoPtr_OnGetObjectType_Protected_Virtual_ObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x00024F92 File Offset: 0x00023192
		public Ingredient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x001975C0 File Offset: 0x001957C0
		// (set) Token: 0x060047D5 RID: 18389 RVA: 0x00024F9B File Offset: 0x0002319B
		public unsafe static int MEAT_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Ingredient.NativeFieldInfoPtr_MEAT_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ingredient.NativeFieldInfoPtr_MEAT_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x001975DC File Offset: 0x001957DC
		// (set) Token: 0x060047D7 RID: 18391 RVA: 0x00024FA9 File Offset: 0x000231A9
		public unsafe static int SEAFOOD_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Ingredient.NativeFieldInfoPtr_SEAFOOD_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ingredient.NativeFieldInfoPtr_SEAFOOD_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x060047D8 RID: 18392 RVA: 0x001975F8 File Offset: 0x001957F8
		// (set) Token: 0x060047D9 RID: 18393 RVA: 0x00024FB7 File Offset: 0x000231B7
		public unsafe static int VEGETABLE_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Ingredient.NativeFieldInfoPtr_VEGETABLE_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ingredient.NativeFieldInfoPtr_VEGETABLE_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x00197614 File Offset: 0x00195814
		// (set) Token: 0x060047DB RID: 18395 RVA: 0x00024FC5 File Offset: 0x000231C5
		public unsafe int prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ingredient.NativeFieldInfoPtr_prefix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ingredient.NativeFieldInfoPtr_prefix)) = value;
			}
		}

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeFieldInfoPtr_MEAT_TAG_ID;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeFieldInfoPtr_SEAFOOD_TAG_ID;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeFieldInfoPtr_VEGETABLE_TAG_ID;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFish_Public_get_Boolean_0;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMeat_Public_get_Boolean_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVeg_Public_get_Boolean_0;

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_Int32_0;

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_Int32_0;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeMethodInfoPtr_Duplicate_Public_Ingredient_0;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeMethodInfoPtr_OnGetObjectType_Protected_Virtual_ObjectType_0;

		// Token: 0x02000AB7 RID: 2743
		public new enum SortType
		{
			// Token: 0x04008441 RID: 33857
			ID,
			// Token: 0x04008442 RID: 33858
			Level,
			// Token: 0x04008443 RID: 33859
			Value,
			// Token: 0x04008444 RID: 33860
			Stack,
			// Token: 0x04008445 RID: 33861
			Tag
		}
	}
}
