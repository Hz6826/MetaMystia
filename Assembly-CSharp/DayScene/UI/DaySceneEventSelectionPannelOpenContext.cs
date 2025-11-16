using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.UI
{
	// Token: 0x020000BF RID: 191
	public sealed class DaySceneEventSelectionPannelOpenContext : ValueType
	{
		// Token: 0x06001574 RID: 5492 RVA: 0x000E6AB4 File Offset: 0x000E4CB4
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneEventSelectionPannelOpenContext()
		{
			Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneEventSelectionPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr);
			DaySceneEventSelectionPannelOpenContext.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr, "Options");
			DaySceneEventSelectionPannelOpenContext.NativeFieldInfoPtr_UseCustomTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr, "UseCustomTitle");
			DaySceneEventSelectionPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr, 100667144);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000E6B20 File Offset: 0x000E4D20
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 60822, RefRangeEnd = 60840, XrefRangeStart = 60821, XrefRangeEnd = 60822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneEventSelectionPannelOpenContext(Dictionary<string, Action> options, bool useCustomTitle) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCustomTitle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneEventSelectionPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Action_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		public DaySceneEventSelectionPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0000D5E1 File Offset: 0x0000B7E1
		public DaySceneEventSelectionPannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneEventSelectionPannelOpenContext>.NativeClassPtr))
		{
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x000E6B80 File Offset: 0x000E4D80
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000D5F3 File Offset: 0x0000B7F3
		public unsafe Dictionary<string, Action> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannelOpenContext.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannelOpenContext.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x000E6BB0 File Offset: 0x000E4DB0
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000D612 File Offset: 0x0000B812
		public unsafe bool UseCustomTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannelOpenContext.NativeFieldInfoPtr_UseCustomTitle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneEventSelectionPannelOpenContext.NativeFieldInfoPtr_UseCustomTitle)) = value;
			}
		}

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr_UseCustomTitle;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Action_Boolean_0;
	}
}
