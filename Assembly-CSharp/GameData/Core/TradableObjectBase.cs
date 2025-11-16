using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace GameData.Core
{
	// Token: 0x02000234 RID: 564
	[Serializable]
	public class TradableObjectBase : NonTradableObjectBase
	{
		// Token: 0x06004680 RID: 18048 RVA: 0x00192390 File Offset: 0x00190590
		// Note: this type is marked as 'beforefieldinit'.
		static TradableObjectBase()
		{
			Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core", "TradableObjectBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr);
			TradableObjectBase.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, "level");
			TradableObjectBase.NativeFieldInfoPtr_baseValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, "baseValue");
			TradableObjectBase.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, "tags");
			TradableObjectBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677276);
			TradableObjectBase.NativeMethodInfoPtr_get_Level_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677277);
			TradableObjectBase.NativeMethodInfoPtr_get_BaseValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677278);
			TradableObjectBase.NativeMethodInfoPtr_get_TrueValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677279);
			TradableObjectBase.NativeMethodInfoPtr_get_Tags_Public_Virtual_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677280);
			TradableObjectBase.NativeMethodInfoPtr_get_RawTags_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677281);
			TradableObjectBase.NativeMethodInfoPtr_OnGetObjectType_Protected_Abstract_Virtual_New_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677282);
			TradableObjectBase.NativeMethodInfoPtr_GetGlobalKey_Private_KeyValuePair_2_ObjectType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr, 100677283);
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x0019249C File Offset: 0x0019069C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 185795, RefRangeEnd = 185800, XrefRangeStart = 185793, XrefRangeEnd = 185795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TradableObjectBase(int id, int level, int baseValue, Il2CppStructArray<int> tags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradableObjectBase>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradableObjectBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x00192514 File Offset: 0x00190714
		public unsafe int Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradableObjectBase.NativeMethodInfoPtr_get_Level_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x00192550 File Offset: 0x00190750
		public unsafe int BaseValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradableObjectBase.NativeMethodInfoPtr_get_BaseValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x0019258C File Offset: 0x0019078C
		public unsafe int TrueValue
		{
			[CallerCount(80)]
			[CachedScanResults(RefRangeStart = 185817, RefRangeEnd = 185897, XrefRangeStart = 185800, XrefRangeEnd = 185817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradableObjectBase.NativeMethodInfoPtr_get_TrueValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x001925C8 File Offset: 0x001907C8
		public unsafe virtual Il2CppStructArray<int> Tags
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TradableObjectBase.NativeMethodInfoPtr_get_Tags_Public_Virtual_New_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x00192614 File Offset: 0x00190814
		public unsafe Il2CppStructArray<int> RawTags
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradableObjectBase.NativeMethodInfoPtr_get_RawTags_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x00192654 File Offset: 0x00190854
		[CallerCount(0)]
		public unsafe virtual SchedulerNode.Reward.ObjectType OnGetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TradableObjectBase.NativeMethodInfoPtr_OnGetObjectType_Protected_Abstract_Virtual_New_ObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x0019269C File Offset: 0x0019089C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185897, XrefRangeEnd = 185900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair<SchedulerNode.Reward.ObjectType, int> GetGlobalKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TradableObjectBase.NativeMethodInfoPtr_GetGlobalKey_Private_KeyValuePair_2_ObjectType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new KeyValuePair<SchedulerNode.Reward.ObjectType, int>(pointer);
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x00024A61 File Offset: 0x00022C61
		public TradableObjectBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x001926D4 File Offset: 0x001908D4
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x00024A6A File Offset: 0x00022C6A
		public unsafe int level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TradableObjectBase.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TradableObjectBase.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x001926FC File Offset: 0x001908FC
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x00024A85 File Offset: 0x00022C85
		public unsafe int baseValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TradableObjectBase.NativeFieldInfoPtr_baseValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TradableObjectBase.NativeFieldInfoPtr_baseValue)) = value;
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x00192724 File Offset: 0x00190924
		// (set) Token: 0x0600468F RID: 18063 RVA: 0x00024AA0 File Offset: 0x00022CA0
		public unsafe Il2CppStructArray<int> tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TradableObjectBase.NativeFieldInfoPtr_tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TradableObjectBase.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400304D RID: 12365
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x0400304E RID: 12366
		private static readonly IntPtr NativeFieldInfoPtr_baseValue;

		// Token: 0x0400304F RID: 12367
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003050 RID: 12368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003051 RID: 12369
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_Int32_0;

		// Token: 0x04003052 RID: 12370
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseValue_Public_get_Int32_0;

		// Token: 0x04003053 RID: 12371
		private static readonly IntPtr NativeMethodInfoPtr_get_TrueValue_Public_get_Int32_0;

		// Token: 0x04003054 RID: 12372
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_Virtual_New_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003055 RID: 12373
		private static readonly IntPtr NativeMethodInfoPtr_get_RawTags_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003056 RID: 12374
		private static readonly IntPtr NativeMethodInfoPtr_OnGetObjectType_Protected_Abstract_Virtual_New_ObjectType_0;

		// Token: 0x04003057 RID: 12375
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalKey_Private_KeyValuePair_2_ObjectType_Int32_0;

		// Token: 0x02000AA2 RID: 2722
		public enum SortType
		{
			// Token: 0x04008329 RID: 33577
			ID,
			// Token: 0x0400832A RID: 33578
			Level,
			// Token: 0x0400832B RID: 33579
			Value
		}
	}
}
