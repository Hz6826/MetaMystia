using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Profile
{
	// Token: 0x020002F0 RID: 752
	[Serializable]
	public class TagRule : Object
	{
		// Token: 0x06005A58 RID: 23128 RVA: 0x001CD1CC File Offset: 0x001CB3CC
		// Note: this type is marked as 'beforefieldinit'.
		static TagRule()
		{
			Il2CppClassPointerStore<TagRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "TagRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagRule>.NativeClassPtr);
			TagRule.NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagRule>.NativeClassPtr, "rule");
			TagRule.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagRule>.NativeClassPtr, 100681430);
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x001CD224 File Offset: 0x001CB424
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TagRule(Il2CppStructArray<int> rule) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TagRule>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TagRule.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00030D1F File Offset: 0x0002EF1F
		public TagRule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x001CD270 File Offset: 0x001CB470
		// (set) Token: 0x06005A5C RID: 23132 RVA: 0x00030D28 File Offset: 0x0002EF28
		public unsafe Il2CppStructArray<int> rule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRule.NativeFieldInfoPtr_rule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRule.NativeFieldInfoPtr_rule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C25 RID: 15397
		private static readonly IntPtr NativeFieldInfoPtr_rule;

		// Token: 0x04003C26 RID: 15398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0;
	}
}
