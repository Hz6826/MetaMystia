using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E0 RID: 480
	public class NS_AMGuest_Spawn_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C3F RID: 15423 RVA: 0x0016B6B0 File Offset: 0x001698B0
		// Note: this type is marked as 'beforefieldinit'.
		static NS_AMGuest_Spawn_Behaviour()
		{
			Il2CppClassPointerStore<NS_AMGuest_Spawn_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_AMGuest_Spawn_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_AMGuest_Spawn_Behaviour>.NativeClassPtr);
			NS_AMGuest_Spawn_Behaviour.NativeFieldInfoPtr_specialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_AMGuest_Spawn_Behaviour>.NativeClassPtr, "specialGuestId");
			NS_AMGuest_Spawn_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_Spawn_Behaviour>.NativeClassPtr, 100674477);
			NS_AMGuest_Spawn_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_AMGuest_Spawn_Behaviour>.NativeClassPtr, 100674478);
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x0016B71C File Offset: 0x0016991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136705, XrefRangeEnd = 136716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_AMGuest_Spawn_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0016B758 File Offset: 0x00169958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_AMGuest_Spawn_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_AMGuest_Spawn_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_AMGuest_Spawn_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x00021D0D File Offset: 0x0001FF0D
		public NS_AMGuest_Spawn_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x0016B794 File Offset: 0x00169994
		// (set) Token: 0x06003C44 RID: 15428 RVA: 0x00021D16 File Offset: 0x0001FF16
		public unsafe int specialGuestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_AMGuest_Spawn_Behaviour.NativeFieldInfoPtr_specialGuestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_AMGuest_Spawn_Behaviour.NativeFieldInfoPtr_specialGuestId)) = value;
			}
		}

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestId;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
