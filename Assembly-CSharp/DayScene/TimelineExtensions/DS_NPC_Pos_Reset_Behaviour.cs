using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000140 RID: 320
	public class DS_NPC_Pos_Reset_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002639 RID: 9785 RVA: 0x0011EA14 File Offset: 0x0011CC14
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Reset_Behaviour()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Reset_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Reset_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Behaviour>.NativeClassPtr);
			DS_NPC_Pos_Reset_Behaviour.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Behaviour>.NativeClassPtr, "characterLabel");
			DS_NPC_Pos_Reset_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Behaviour>.NativeClassPtr, 100670170);
			DS_NPC_Pos_Reset_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Behaviour>.NativeClassPtr, 100670171);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0011EA80 File Offset: 0x0011CC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90163, XrefRangeEnd = 90169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Reset_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x0011EABC File Offset: 0x0011CCBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Reset_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Reset_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000168F8 File Offset: 0x00014AF8
		public DS_NPC_Pos_Reset_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x0011EAF8 File Offset: 0x0011CCF8
		// (set) Token: 0x0600263E RID: 9790 RVA: 0x00016901 File Offset: 0x00014B01
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Reset_Behaviour.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Reset_Behaviour.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
