using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000421 RID: 1057
	public class COM_Camera_Shake_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007856 RID: 30806 RVA: 0x0022E60C File Offset: 0x0022C80C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_Shake_Behaviour()
		{
			Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_Shake_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr);
			COM_Camera_Shake_Behaviour.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr, "amplitude");
			COM_Camera_Shake_Behaviour.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr, "duration");
			COM_Camera_Shake_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr, 100687625);
			COM_Camera_Shake_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr, 100687626);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x0022E68C File Offset: 0x0022C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293505, XrefRangeEnd = 293509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_Shake_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x0022E6C8 File Offset: 0x0022C8C8
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_Shake_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_Shake_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_Shake_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x000411A9 File Offset: 0x0003F3A9
		public COM_Camera_Shake_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600785A RID: 30810 RVA: 0x0022E704 File Offset: 0x0022C904
		// (set) Token: 0x0600785B RID: 30811 RVA: 0x000411B2 File Offset: 0x0003F3B2
		public unsafe float amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake_Behaviour.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake_Behaviour.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600785C RID: 30812 RVA: 0x0022E72C File Offset: 0x0022C92C
		// (set) Token: 0x0600785D RID: 30813 RVA: 0x000411CD File Offset: 0x0003F3CD
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake_Behaviour.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_Shake_Behaviour.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x04004F5C RID: 20316
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04004F5D RID: 20317
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04004F5E RID: 20318
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F5F RID: 20319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
