using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000185 RID: 389
	public class MakaiMushroomBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002A83 RID: 10883 RVA: 0x0012BC3C File Offset: 0x00129E3C
		// Note: this type is marked as 'beforefieldinit'.
		static MakaiMushroomBehaviourComponent()
		{
			Il2CppClassPointerStore<MakaiMushroomBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MakaiMushroomBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MakaiMushroomBehaviourComponent>.NativeClassPtr);
			MakaiMushroomBehaviourComponent.NativeFieldInfoPtr_m_InteractDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MakaiMushroomBehaviourComponent>.NativeClassPtr, "m_InteractDialog");
			MakaiMushroomBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakaiMushroomBehaviourComponent>.NativeClassPtr, 100670696);
			MakaiMushroomBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakaiMushroomBehaviourComponent>.NativeClassPtr, 100670697);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x0012BCA8 File Offset: 0x00129EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95361, XrefRangeEnd = 95365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MakaiMushroomBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0012BCE4 File Offset: 0x00129EE4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MakaiMushroomBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MakaiMushroomBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MakaiMushroomBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00018D4B File Offset: 0x00016F4B
		public MakaiMushroomBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x0012BD20 File Offset: 0x00129F20
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x00018D54 File Offset: 0x00016F54
		public unsafe DialogPackage m_InteractDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MakaiMushroomBehaviourComponent.NativeFieldInfoPtr_m_InteractDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MakaiMushroomBehaviourComponent.NativeFieldInfoPtr_m_InteractDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeFieldInfoPtr_m_InteractDialog;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
