using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000143 RID: 323
	public class DS_NPC_Pos_Reset_Effect_Behaviour : DS_NPC_Pos_Effect_Behaviour
	{
		// Token: 0x06002663 RID: 9827 RVA: 0x0011F21C File Offset: 0x0011D41C
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Reset_Effect_Behaviour()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Reset_Effect_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Reset_Effect_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Effect_Behaviour>.NativeClassPtr);
			DS_NPC_Pos_Reset_Effect_Behaviour.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Effect_Behaviour>.NativeClassPtr, 100670188);
			DS_NPC_Pos_Reset_Effect_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Effect_Behaviour>.NativeClassPtr, 100670189);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0011F274 File Offset: 0x0011D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90216, XrefRangeEnd = 90218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(string characterLabel, bool timeContinue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeContinue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Reset_Effect_Behaviour.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x0011F2D0 File Offset: 0x0011D4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Reset_Effect_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Reset_Effect_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Reset_Effect_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00016A6B File Offset: 0x00014C6B
		public DS_NPC_Pos_Reset_Effect_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_String_Boolean_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
