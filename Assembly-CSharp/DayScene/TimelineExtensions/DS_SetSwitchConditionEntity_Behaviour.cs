using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200014A RID: 330
	public class DS_SetSwitchConditionEntity_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600269F RID: 9887 RVA: 0x0011FC14 File Offset: 0x0011DE14
		// Note: this type is marked as 'beforefieldinit'.
		static DS_SetSwitchConditionEntity_Behaviour()
		{
			Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_SetSwitchConditionEntity_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr);
			DS_SetSwitchConditionEntity_Behaviour.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr, "on");
			DS_SetSwitchConditionEntity_Behaviour.NativeFieldInfoPtr_visualEntityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr, "visualEntityLabel");
			DS_SetSwitchConditionEntity_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr, 100670206);
			DS_SetSwitchConditionEntity_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr, 100670207);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0011FC94 File Offset: 0x0011DE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90311, XrefRangeEnd = 90312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_SetSwitchConditionEntity_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0011FCD0 File Offset: 0x0011DED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_SetSwitchConditionEntity_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_SetSwitchConditionEntity_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_SetSwitchConditionEntity_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00016C53 File Offset: 0x00014E53
		public DS_SetSwitchConditionEntity_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x0011FD0C File Offset: 0x0011DF0C
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x00016C5C File Offset: 0x00014E5C
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity_Behaviour.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity_Behaviour.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x0011FD34 File Offset: 0x0011DF34
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x00016C77 File Offset: 0x00014E77
		public unsafe string visualEntityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity_Behaviour.NativeFieldInfoPtr_visualEntityLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity_Behaviour.NativeFieldInfoPtr_visualEntityLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr_visualEntityLabel;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
