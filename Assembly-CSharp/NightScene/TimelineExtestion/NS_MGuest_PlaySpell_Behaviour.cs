using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001EE RID: 494
	public class NS_MGuest_PlaySpell_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003CB5 RID: 15541 RVA: 0x0016CA80 File Offset: 0x0016AC80
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_PlaySpell_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_PlaySpell_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr);
			NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_isPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr, "isPositive");
			NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr, "label");
			NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_visualOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr, "visualOnly");
			NS_MGuest_PlaySpell_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr, 100674518);
			NS_MGuest_PlaySpell_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr, 100674519);
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x0016CB14 File Offset: 0x0016AD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136956, XrefRangeEnd = 136966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_PlaySpell_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x0016CB50 File Offset: 0x0016AD50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_PlaySpell_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_PlaySpell_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_PlaySpell_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x0002208D File Offset: 0x0002028D
		public NS_MGuest_PlaySpell_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x0016CB8C File Offset: 0x0016AD8C
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x00022096 File Offset: 0x00020296
		public unsafe bool isPositive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_isPositive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_isPositive)) = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x0016CBB4 File Offset: 0x0016ADB4
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x000220B1 File Offset: 0x000202B1
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0016CBDC File Offset: 0x0016ADDC
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x000220D0 File Offset: 0x000202D0
		public unsafe bool visualOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_visualOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell_Behaviour.NativeFieldInfoPtr_visualOnly)) = value;
			}
		}

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeFieldInfoPtr_isPositive;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeFieldInfoPtr_visualOnly;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
