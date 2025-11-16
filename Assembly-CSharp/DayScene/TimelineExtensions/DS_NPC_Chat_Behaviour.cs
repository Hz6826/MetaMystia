using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200014B RID: 331
	public class DS_NPC_Chat_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x060026A7 RID: 9895 RVA: 0x0011FD5C File Offset: 0x0011DF5C
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Chat_Behaviour()
		{
			Il2CppClassPointerStore<DS_NPC_Chat_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Chat_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Chat_Behaviour>.NativeClassPtr);
			DS_NPC_Chat_Behaviour.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Chat_Behaviour>.NativeClassPtr, "characterLabel");
			DS_NPC_Chat_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Chat_Behaviour>.NativeClassPtr, 100670208);
			DS_NPC_Chat_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Chat_Behaviour>.NativeClassPtr, 100670209);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0011FDC8 File Offset: 0x0011DFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90312, XrefRangeEnd = 90322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Chat_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0011FE04 File Offset: 0x0011E004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Chat_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Chat_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Chat_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00016C96 File Offset: 0x00014E96
		public DS_NPC_Chat_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x0011FE40 File Offset: 0x0011E040
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x00016C9F File Offset: 0x00014E9F
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Chat_Behaviour.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Chat_Behaviour.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
