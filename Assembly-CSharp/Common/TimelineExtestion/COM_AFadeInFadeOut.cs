using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F1 RID: 1009
	public class COM_AFadeInFadeOut : PlayableAsset
	{
		// Token: 0x060076BE RID: 30398 RVA: 0x00229E64 File Offset: 0x00228064
		// Note: this type is marked as 'beforefieldinit'.
		static COM_AFadeInFadeOut()
		{
			Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_AFadeInFadeOut");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr);
			COM_AFadeInFadeOut.NativeFieldInfoPtr_transitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr, "transitionType");
			COM_AFadeInFadeOut.NativeFieldInfoPtr_notWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr, "notWait");
			COM_AFadeInFadeOut.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr, 100687525);
			COM_AFadeInFadeOut.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr, 100687526);
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00229EE4 File Offset: 0x002280E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292872, XrefRangeEnd = 292886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_AFadeInFadeOut.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00229F4C File Offset: 0x0022814C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_AFadeInFadeOut() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_AFadeInFadeOut>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_AFadeInFadeOut.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x0004040F File Offset: 0x0003E60F
		public COM_AFadeInFadeOut(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x060076C2 RID: 30402 RVA: 0x00229F88 File Offset: 0x00228188
		// (set) Token: 0x060076C3 RID: 30403 RVA: 0x00040418 File Offset: 0x0003E618
		public unsafe COM_AFadeInFadeOut_Behaviour.Type transitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut.NativeFieldInfoPtr_transitionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut.NativeFieldInfoPtr_transitionType)) = value;
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x00229FB0 File Offset: 0x002281B0
		// (set) Token: 0x060076C5 RID: 30405 RVA: 0x00040433 File Offset: 0x0003E633
		public unsafe bool notWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut.NativeFieldInfoPtr_notWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut.NativeFieldInfoPtr_notWait)) = value;
			}
		}

		// Token: 0x04004E8E RID: 20110
		private static readonly IntPtr NativeFieldInfoPtr_transitionType;

		// Token: 0x04004E8F RID: 20111
		private static readonly IntPtr NativeFieldInfoPtr_notWait;

		// Token: 0x04004E90 RID: 20112
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E91 RID: 20113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
